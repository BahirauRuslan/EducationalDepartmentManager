using System;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class PlanContentForm : Form
    {
        public PlanContentForm()
        {
            this.InitializeComponent();
        }

        private void PlansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void PlanContentForm_Load(object sender, EventArgs e)
        {
            this.subjectsTableAdapter.Fill(this.educationalDepartmentDataSet.Subjects);
            this.planContentTableAdapter.Fill(this.educationalDepartmentDataSet.PlanContent);
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
        }
    }
}
