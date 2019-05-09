using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class MainFrom : Form
    {
        private readonly Lazy<SubjectsForm> _subjectsForm = new Lazy<SubjectsForm>();

        public MainFrom()
        {
            this.InitializeComponent();
        }

        private void ShowDialogForm(Form form)
        {
            if (form is null)
            {
                throw new ArgumentNullException("Form must not be null");
            }

            form.ShowDialog();
        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {
            this.ShowDialogForm(this._subjectsForm.Value);
        }
    }
}
