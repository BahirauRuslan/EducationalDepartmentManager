using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DepartmentManager
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (this.Owner is MarkRecordsForm main && !string.IsNullOrEmpty(main.groupsComboBox.Text) 
                && main.planContentDataGridView.RowCount > 1 && main.markRecordsDataGridView.RowCount > 1)
            {
                var mainLabel = new ReportParameter("mainLabel", "Ведомость");
                var headerText = $"группы №{main.groupsComboBox.Text} " +
                    $"по дисциплине { main.planContentDataGridView[1, main.planContentDataGridView.CurrentRow.Index].FormattedValue.ToString() } (лекции - " +
                    $"{ main.planContentDataGridView[2, main.planContentDataGridView.CurrentRow.Index].Value.ToString() }ч, лабораторные - " +
                    $"{ main.planContentDataGridView[3, main.planContentDataGridView.CurrentRow.Index].Value.ToString() }ч, курсовые - " +
                    $"{ main.planContentDataGridView[4, main.planContentDataGridView.CurrentRow.Index].Value.ToString() }ч)";
                var header = new ReportParameter("header", headerText);
                var bodyBuilder = new StringBuilder();
                for (var i = 0; i < main.markRecordsDataGridView.RowCount - 1; i++)
                {
                    bodyBuilder.Append(main.markRecordsDataGridView[0, i].FormattedValue.ToString());
                    bodyBuilder.Append(" - ");
                    bodyBuilder.Append(main.markRecordsDataGridView[1, i].Value.ToString());
                    bodyBuilder.Append("\n");
                }

                var body = new ReportParameter("body", bodyBuilder.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { header, body, mainLabel });
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
