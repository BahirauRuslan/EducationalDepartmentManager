using System;
using System.Linq;
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
            try
            {
                this.Validate();
                this.plansBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.educationalDepartmentDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Оценка должна быть в пределах от 0 до 10", "Ошибка сохранения");
            }
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

        private void GroupsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (this.groupsBindingSource.Current != null)
            {
                var ids = (from student in this.educationalDepartmentDataSet.Students.AsQueryable()
                           where student.GroupId == int.Parse(((System.Data.DataRowView)this.groupsBindingSource.Current)["Id"].ToString())
                           select student.Id.ToString()).ToArray();
                var groupedIds = string.Join(", ", ids);
                this.markRecordsBindingSource.Filter = groupedIds.Length > 1 ? $"StudentId IN ({groupedIds})" : $"StudentId IN (-1)";
            }
        }

        private void MarkRecordsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Не выбран студент или поставлена некорректная оценка", "Ошибка ввода");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm
            {
                Owner = this
            };
            reportForm.ShowDialog();
        }
    }
}
