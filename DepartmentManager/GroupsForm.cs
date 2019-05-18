using System;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            this.InitializeComponent();
        }

        private void PlansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.plansBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Номер группы должен состоять из восьми цифр (первая не может быть нулем)", "Ошибка сохранения");
            }
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            this.groupsTableAdapter.Fill(this.educationalDepartmentDataSet.Groups);
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
        }
    }
}
