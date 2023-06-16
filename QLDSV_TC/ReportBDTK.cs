using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.PivotGrid;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class ReportBDTK : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBDTK()
        {
            InitializeComponent();
        }

        public ReportBDTK(string maLop)
        {
            try
            {
                InitializeComponent();
                this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource2.Queries[0].Parameters[0].Value = maLop;
                this.sqlDataSource2.Fill();

                this.BeforePrint += ReportBDTK_BeforePrint;

            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        private void ReportBDTK_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Access the XRPivotGrid control and adjust column widths
            XRPivotGrid pivotGrid = xrPivotGrid1;
            foreach (XRPivotGridField field in pivotGrid.Fields)
            {
                field.BestFit();
            }
        }

    }
}
