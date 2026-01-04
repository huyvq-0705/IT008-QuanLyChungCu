-- =========================
-- PostgreSQL schema 
-- =========================

-- ===== Staff =====
CREATE TABLE staff (
  id              SERIAL PRIMARY KEY,
  username        VARCHAR(50)  NOT NULL UNIQUE,
  password_hash   TEXT         NOT NULL,
  full_name       VARCHAR(100) NOT NULL,
  phone           VARCHAR(20),
  email           VARCHAR(100),
  role            VARCHAR(20)  NOT NULL, -- STAFF
  is_active       BOOLEAN      NOT NULL DEFAULT TRUE,
  created_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted      BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at      TIMESTAMPTZ
);

-- ===== Unit Type (NEW – normalized) =====
CREATE TABLE unit_type (
  id          SERIAL PRIMARY KEY,
  label       VARCHAR(50) NOT NULL UNIQUE,
  created_at  TIMESTAMPTZ NOT NULL DEFAULT now()
);

-- ===== Units =====
CREATE TABLE unit (
  id              SERIAL PRIMARY KEY,
  unit_code       VARCHAR(20)  NOT NULL UNIQUE,
  floor_no        INT          NOT NULL,
  area_m2         NUMERIC(8,2) NOT NULL,
  unit_type_id    INT          NOT NULL,
  monthly_rent    NUMERIC(12,2) NOT NULL,
  status          VARCHAR(20)  NOT NULL DEFAULT 'VACANT', -- VACANT | OCCUPIED | MAINTENANCE
  created_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted      BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at      TIMESTAMPTZ,
  CONSTRAINT fk_unit_type
    FOREIGN KEY (unit_type_id)
    REFERENCES unit_type(id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

-- ===== Household =====
CREATE TABLE household (
  id              SERIAL PRIMARY KEY,
  unit_id         INT          NOT NULL,
  start_date      DATE         NOT NULL,
  end_date        DATE,
  note            TEXT,
  created_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at      TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted      BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at      TIMESTAMPTZ,
  CONSTRAINT fk_household_unit
    FOREIGN KEY (unit_id)
    REFERENCES unit(id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

-- ===== Household Members =====
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
    FOREIGN KEY (household_id)
    REFERENCES household(id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- ===== Tariff =====
CREATE TABLE tariff (
  id            SERIAL PRIMARY KEY,
  name          VARCHAR(50) NOT NULL UNIQUE, -- ELECTRICITY | WATER
  rate_per_unit NUMERIC(10,2) NOT NULL,
  updated_at    TIMESTAMPTZ NOT NULL DEFAULT now()
);

-- ===== Meter Reading =====
CREATE TABLE meter_reading (
  id                     SERIAL PRIMARY KEY,
  unit_id                INT          NOT NULL,
  tariff_type            VARCHAR(50)  NOT NULL, -- ELECTRICITY | WATER
  period_month           DATE         NOT NULL,
  consumption             NUMERIC(12,3),
  recorded_by_staff_id   INT          NOT NULL,
  note                   TEXT,
  created_at             TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at             TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted             BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at             TIMESTAMPTZ,
  CONSTRAINT fk_meter_unit
    FOREIGN KEY (unit_id)
    REFERENCES unit(id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT fk_meter_staff
    FOREIGN KEY (recorded_by_staff_id)
    REFERENCES staff(id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

CREATE UNIQUE INDEX ux_meter_unit_type_month
  ON meter_reading(unit_id, tariff_type, period_month);

-- ===== Monthly Bill =====
CREATE TABLE monthly_bill (
  id                    SERIAL PRIMARY KEY,
  unit_id               INT          NOT NULL,
  period_month          DATE         NOT NULL,
  rent_amount           NUMERIC(12,2) NOT NULL,
  electricity_amount    NUMERIC(12,2),
  water_amount          NUMERIC(12,2),
  adjustments           NUMERIC(12,2) NOT NULL DEFAULT 0,
  total_amount          NUMERIC(12,2),
  status                VARCHAR(20)  NOT NULL, -- UNPAID | PAID
  issued_at             TIMESTAMPTZ,
  paid_at               TIMESTAMPTZ,
  created_by_staff_id   INT          NOT NULL,
  note                  TEXT,
  created_at            TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at            TIMESTAMPTZ  NOT NULL DEFAULT now(),
  is_deleted            BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at            TIMESTAMPTZ,
  CONSTRAINT fk_bill_unit
    FOREIGN KEY (unit_id)
    REFERENCES unit(id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT fk_bill_staff
    FOREIGN KEY (created_by_staff_id)
    REFERENCES staff(id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

CREATE UNIQUE INDEX ux_bill_unit_month
  ON monthly_bill(unit_id, period_month);

-- ===== Ticket =====
CREATE TABLE ticket (
  id                  SERIAL PRIMARY KEY,
  unit_id             INT          NOT NULL,
  title               VARCHAR(200) NOT NULL,
  description         TEXT         NOT NULL,
  status              VARCHAR(20)  NOT NULL DEFAULT 'OPEN',
  created_by_staff_id INT          NOT NULL,
  created_at          TIMESTAMPTZ  NOT NULL DEFAULT now(),
  updated_at          TIMESTAMPTZ  NOT NULL DEFAULT now(),
  closed_at           TIMESTAMPTZ,
  is_deleted          BOOLEAN      NOT NULL DEFAULT FALSE,
  deleted_at          TIMESTAMPTZ,
  CONSTRAINT fk_ticket_unit
    FOREIGN KEY (unit_id)
    REFERENCES unit(id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT fk_ticket_staff
    FOREIGN KEY (created_by_staff_id)
    REFERENCES staff(id)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

CREATE INDEX ix_ticket_status ON ticket(status);
