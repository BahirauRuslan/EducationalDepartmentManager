using System;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            this.InitializeComponent();
        }

        private void GroupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
            this.studentsTableAdapter.Fill(this.educationalDepartmentDataSet.Students);
            this.groupsTableAdapter.Fill(this.educationalDepartmentDataSet.Groups);
        }

        private void StudentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Имя студента должно содержать от 1 до 25 символов", "Ошибка ввода");
        }
    }
}
