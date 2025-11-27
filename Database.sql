-- =========================
-- PostgreSQL schema for DrawDB (explicit FK constraints)
-- =========================

-- ===== Core: staff (login) =====
CREATE TABLE staff (
  id              SERIAL PRIMARY KEY,
  username        VARCHAR(50)  NOT NULL UNIQUE,
  password_hash   TEXT         NOT NULL,
  full_name       VARCHAR(100) NOT NULL,
  phone           VARCHAR(20),
  email           VARCHAR(100),
  role            VARCHAR(20)  NOT NULL,         -- 'ADMIN' | 'RECEPTION'
  is_active       BOOLEAN      NOT NULL DEFAULT TRUE,
  created_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted      BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at      TIMESTAMPTZ
);

-- ===== Units =====
CREATE TABLE unit (
  id              SERIAL PRIMARY KEY,
  unit_code       VARCHAR(20)  NOT NULL UNIQUE,  -- e.g., '101', '12A'
  floor_no        INT          NOT NULL,
  area_m2         NUMERIC(8,2) NOT NULL,
  bedrooms        INT          NOT NULL,
  bathrooms       INT          NOT NULL,
  unit_type       VARCHAR(30)  NOT NULL,         -- 'Studio','1BR / 1Bathroom','2BR / 1Bathroom', '2BR / 2Bathroom', '3BR / 2Bathroom'
  monthly_rent    NUMERIC(12,2) NOT NULL,
  status          VARCHAR(20)  NOT NULL DEFAULT 'VACANT', -- 'VACANT'|'OCCUPIED'|'MAINTENANCE'
  created_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted      BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at      TIMESTAMPTZ
);

-- ===== Household =====
CREATE TABLE household (
  id              SERIAL PRIMARY KEY,
  unit_id         INT          NOT NULL,
  start_date      DATE         NOT NULL,
  end_date        DATE,                           -- NULL = active
  note            TEXT,
  created_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted      BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at      TIMESTAMPTZ,
  CONSTRAINT fk_household_unit
    FOREIGN KEY (unit_id) REFERENCES unit(id) ON DELETE RESTRICT ON UPDATE CASCADE
);

-- ===== Household members =====
CREATE TABLE household_member (
  id              SERIAL PRIMARY KEY,
  household_id    INT          NOT NULL,
  full_name       VARCHAR(100) NOT NULL,
  relationship    VARCHAR(50),
  phone           VARCHAR(20),
  cccd            VARCHAR(20),
  dob             DATE,
  is_primary      BOOLEAN      NOT NULL DEFAULT FALSE,
  created_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted      BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at      TIMESTAMPTZ,
  CONSTRAINT fk_member_household
    FOREIGN KEY (household_id) REFERENCES household(id) ON DELETE CASCADE ON UPDATE CASCADE
);

-- ===== Tariffs =====
CREATE TYPE tariff_type AS ENUM ('ELECTRICITY', 'WATER');
CREATE TABLE tariff (
  id SERIAL PRIMARY KEY,
  type tariff_type NOT NULL UNIQUE,
  rate_per_unit NUMERIC(10,2) NOT NULL,
  updated_at TIMESTAMPTZ NOT NULL DEFAULT now()
);

-- ===== Meter readings (monthly) =====
CREATE TABLE meter_reading (
  id                    SERIAL PRIMARY KEY,
  unit_id               INT          NOT NULL,
  type                  tariff_type  NOT NULL,
  period_month          DATE         NOT NULL,   -- month + year (use 1st day of month)
  consumption           NUMERIC(12,3),
  recorded_by_staff_id INT           NOT NULL,
  note                  TEXT,
  created_at            TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at            TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted            BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at            TIMESTAMPTZ,

  CONSTRAINT fk_meter_unit
    FOREIGN KEY (unit_id) REFERENCES unit(id) ON DELETE RESTRICT ON UPDATE CASCADE,

  CONSTRAINT fk_meter_staff
    FOREIGN KEY (recorded_by_staff_id) REFERENCES staff(id) ON DELETE RESTRICT ON UPDATE CASCADE
);

-- One reading per unit per type per month
CREATE UNIQUE INDEX ux_meter_reading_unit_type_month
  ON meter_reading(unit_id, type, period_month);


-- ===== Monthly bill =====
CREATE TABLE monthly_bill (
  id                      SERIAL PRIMARY KEY,
  unit_id                 INT           NOT NULL,
  period_month            DATE          NOT NULL,         -- 1st day of month
  rent_amount             NUMERIC(12,2) NOT NULL,
  electricity_amount      NUMERIC(12,2),                  -- compute in app/SQL
  water_amount            NUMERIC(12,2),                  -- compute in app/SQL
  adjustments             NUMERIC(12,2) NOT NULL DEFAULT 0,
  total_amount            NUMERIC(12,2),                  -- compute in app/SQL
  status                  VARCHAR(20)  NOT NULL DEFAULT 'DRAFT',
  issued_at               TIMESTAMPTZ,
  paid_at                 TIMESTAMPTZ,
  created_by_staff_id     INT           NOT NULL,
  note                    TEXT,
  created_at              TIMESTAMPTZ   NOT NULL DEFAULT now(),
  updated_at              TIMESTAMPTZ   NOT NULL DEFAULT now(),
  is_deleted              BOOLEAN       NOT NULL DEFAULT FALSE,
  deleted_at              TIMESTAMPTZ,
  CONSTRAINT fk_bill_unit
    FOREIGN KEY (unit_id) REFERENCES unit(id) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT fk_bill_staff
    FOREIGN KEY (created_by_staff_id) REFERENCES staff(id) ON DELETE RESTRICT ON UPDATE CASCADE
);
CREATE UNIQUE INDEX ux_bill_unit_month ON monthly_bill(unit_id, period_month);


-- ===== Service tickets =====
CREATE TYPE ticket_status AS ENUM (
  'OPEN',
  'IN_PROGRESS',
  'CLOSED',
  'CANCELLED'
);
CREATE TABLE ticket (
  id                  SERIAL PRIMARY KEY,
  unit_id             INT           NOT NULL,
  title               VARCHAR(200) NOT NULL,
  description         TEXT         NOT NULL,
  status              ticket_status NOT NULL DEFAULT 'OPEN',
  created_by_staff_id INT           NOT NULL,
  created_at          TIMESTAMPTZ   NOT NULL DEFAULT now(),
  updated_at          TIMESTAMPTZ   NOT NULL DEFAULT now(),
  closed_at           TIMESTAMPTZ,
  is_deleted          BOOLEAN       NOT NULL DEFAULT FALSE,
  deleted_at          TIMESTAMPTZ,
  CONSTRAINT fk_ticket_unit
    FOREIGN KEY (unit_id) REFERENCES unit(id) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT fk_ticket_staff
    FOREIGN KEY (created_by_staff_id) REFERENCES staff(id) ON DELETE RESTRICT ON UPDATE CASCADE
);
CREATE INDEX ix_ticket_status ON ticket(status);
