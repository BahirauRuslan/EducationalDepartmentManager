using System;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class PlansForm : Form
    {
        public PlansForm()
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
                MessageBox.Show("Нельзя добавлять специальности с неправильным годом (старше 1970г. и еще не наступивший год). " +
                    "Нельзя удалять специальность, которая имеет спланированные дисциплины", "Ошибка сохранения");
            }
        }

        private void PlansForm_Load(object sender, EventArgs e)
        {
            this.plansTableAdapter.Fill(this.educationalDepartmentDataSet.Plans);
        }

        private void PlansDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Название специальности должно содержать от 1 до 75 символов. Год должен быть числовым значением", "Ошибка ввода");
        }
    }
}
