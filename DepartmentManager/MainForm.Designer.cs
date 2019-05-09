namespace DepartmentManager
{
    public partial class MainFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button subjectButton;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.Button planContentButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button markButton;

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
            this.subjectButton = new System.Windows.Forms.Button();
            this.planButton = new System.Windows.Forms.Button();
            this.planContentButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.markButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectButton
            // 
            this.subjectButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectButton.Location = new System.Drawing.Point(12, 12);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Size = new System.Drawing.Size(281, 38);
            this.subjectButton.TabIndex = 0;
            this.subjectButton.Text = "Дисциплины";
            this.subjectButton.UseVisualStyleBackColor = true;
            this.subjectButton.Click += new System.EventHandler(this.SubjectButton_Click);
            // 
            // planButton
            // 
            this.planButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planButton.Location = new System.Drawing.Point(12, 56);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(281, 38);
            this.planButton.TabIndex = 1;
            this.planButton.Text = "Планы";
            this.planButton.UseVisualStyleBackColor = true;
            this.planButton.Click += new System.EventHandler(this.PlanButton_Click);
            // 
            // planContentButton
            // 
            this.planContentButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planContentButton.Location = new System.Drawing.Point(12, 100);
            this.planContentButton.Name = "planContentButton";
            this.planContentButton.Size = new System.Drawing.Size(281, 38);
            this.planContentButton.TabIndex = 2;
            this.planContentButton.Text = "Содержание плана";
            this.planContentButton.UseVisualStyleBackColor = true;
            // 
            // groupButton
            // 
            this.groupButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupButton.Location = new System.Drawing.Point(12, 144);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(281, 38);
            this.groupButton.TabIndex = 3;
            this.groupButton.Text = "Группы";
            this.groupButton.UseVisualStyleBackColor = true;
            // 
            // studentButton
            // 
            this.studentButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentButton.Location = new System.Drawing.Point(12, 188);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(281, 38);
            this.studentButton.TabIndex = 4;
            this.studentButton.Text = "Студенты";
            this.studentButton.UseVisualStyleBackColor = true;
            // 
            // markButton
            // 
            this.markButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markButton.Location = new System.Drawing.Point(12, 232);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(281, 38);
            this.markButton.TabIndex = 5;
            this.markButton.Text = "Оценки";
            this.markButton.UseVisualStyleBackColor = true;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 282);
            this.Controls.Add(this.markButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.planContentButton);
            this.Controls.Add(this.planButton);
            this.Controls.Add(this.subjectButton);
            this.Name = "MainFrom";
            this.Text = "Учет успеваемости студентов";
            this.ResumeLayout(false);

        }

        #endregion
    }
}