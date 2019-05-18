using System;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            this.InitializeComponent();
        }

        private void SubjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            this.subjectsTableAdapter.Fill(this.educationalDepartmentDataSet.Subjects);
        }

        private void SubjectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Название дисциплины должно содержать от 1 до 75 символов", "Ошибка ввода");
        }
    }
}
