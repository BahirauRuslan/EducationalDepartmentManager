using System;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class MarkRecordsForm : Form
    {
        public MarkRecordsForm()
        {
            this.InitializeComponent();
        }

        private void PlansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void MarkRecordsForm_Load(object sender, EventArgs e)
        {
            this.markRecordsTableAdapter.Fill(this.educationalDepartmentDataSet.MarkRecords);
            this.subjectsTableAdapter.Fill(this.educationalDepartmentDataSet.Subjects);
            this.planContentTableAdapter.Fill(this.educationalDepartmentDataSet.PlanContent);
            this.studentsTableAdapter.Fill(this.educationalDepartmentDataSet.Students);
            this.groupsTableAdapter.Fill(this.educationalDepartmentDataSet.Groups);
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
        }
    }
}
