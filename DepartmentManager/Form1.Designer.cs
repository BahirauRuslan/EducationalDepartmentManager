namespace DepartmentManager
{
    public partial class MainFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage subjectsPage;
        private System.Windows.Forms.TabPage plansPage;
        private System.Windows.Forms.TabPage planContentPage;
        private System.Windows.Forms.TabPage groupsPage;
        private System.Windows.Forms.TabPage studentsPage;
        private System.Windows.Forms.TabPage marksPage;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.subjectsPage = new System.Windows.Forms.TabPage();
            this.plansPage = new System.Windows.Forms.TabPage();
            this.planContentPage = new System.Windows.Forms.TabPage();
            this.groupsPage = new System.Windows.Forms.TabPage();
            this.studentsPage = new System.Windows.Forms.TabPage();
            this.marksPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.subjectsPage);
            this.tabControl1.Controls.Add(this.plansPage);
            this.tabControl1.Controls.Add(this.planContentPage);
            this.tabControl1.Controls.Add(this.groupsPage);
            this.tabControl1.Controls.Add(this.studentsPage);
            this.tabControl1.Controls.Add(this.marksPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // subjectsPage
            // 
            this.subjectsPage.Location = new System.Drawing.Point(4, 22);
            this.subjectsPage.Name = "subjectsPage";
            this.subjectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsPage.Size = new System.Drawing.Size(712, 264);
            this.subjectsPage.TabIndex = 0;
            this.subjectsPage.Text = "Дисциплины";
            this.subjectsPage.UseVisualStyleBackColor = true;
            // 
            // plansPage
            // 
            this.plansPage.Location = new System.Drawing.Point(4, 22);
            this.plansPage.Name = "plansPage";
            this.plansPage.Padding = new System.Windows.Forms.Padding(3);
            this.plansPage.Size = new System.Drawing.Size(712, 264);
            this.plansPage.TabIndex = 1;
            this.plansPage.Text = "Планы";
            this.plansPage.UseVisualStyleBackColor = true;
            // 
            // planContentPage
            // 
            this.planContentPage.Location = new System.Drawing.Point(4, 22);
            this.planContentPage.Name = "planContentPage";
            this.planContentPage.Size = new System.Drawing.Size(712, 264);
            this.planContentPage.TabIndex = 2;
            this.planContentPage.Text = "Содержание плана";
            this.planContentPage.UseVisualStyleBackColor = true;
            // 
            // groupsPage
            // 
            this.groupsPage.Location = new System.Drawing.Point(4, 22);
            this.groupsPage.Name = "groupsPage";
            this.groupsPage.Size = new System.Drawing.Size(712, 264);
            this.groupsPage.TabIndex = 3;
            this.groupsPage.Text = "Группы";
            this.groupsPage.UseVisualStyleBackColor = true;
            // 
            // studentsPage
            // 
            this.studentsPage.Location = new System.Drawing.Point(4, 22);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.Size = new System.Drawing.Size(712, 264);
            this.studentsPage.TabIndex = 4;
            this.studentsPage.Text = "Студенты";
            this.studentsPage.UseVisualStyleBackColor = true;
            // 
            // marksPage
            // 
            this.marksPage.Location = new System.Drawing.Point(4, 22);
            this.marksPage.Name = "marksPage";
            this.marksPage.Size = new System.Drawing.Size(712, 264);
            this.marksPage.TabIndex = 5;
            this.marksPage.Text = "Успеваемость";
            this.marksPage.UseVisualStyleBackColor = true;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 314);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFrom";
            this.Text = "Учет успеваемости студентов";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}