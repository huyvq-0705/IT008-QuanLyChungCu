using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT008_Quản_Lý_Chung_Cư.Controls
{
    public partial class MeterReadingUnitItemControl : UserControl
    {
        private int _unitId;
        private string _unitCode;
        private int _staffId;

        public MeterReadingUnitItemControl(int unitId, string unitCode, string primaryOwner, int staffId)
        {
            InitializeComponent();
            _unitId = unitId;
            _unitCode = unitCode;
            _staffId = staffId;

            lblMainInfo.Text = $"Unit_Code: {unitCode}   Primary_Owner: {primaryOwner}";

            // Click events to open details
            this.Click += (s, e) => OpenDetails();
            btnView.Click += (s, e) => OpenDetails();
            lblMainInfo.Click += (s, e) => OpenDetails();
        }

        private void OpenDetails()
        {
            // Open the details form, passing UnitID, UnitCode, and StaffID
            MeterReadingDetails_Form form = new MeterReadingDetails_Form(_unitId, _unitCode, _staffId);
            form.ShowDialog();
        }
    }
}