namespace DepartmentManager
{
    public partial class PlanContentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private EducationalDepartmentDataSet educationalDepartmentDataSet;
        private System.Windows.Forms.BindingSource plansBindingSource;
        private EducationalDepartmentDataSetTableAdapters.PlansTableAdapter plansTableAdapter;
        private EducationalDepartmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator plansBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton plansBindingNavigatorSaveItem;
        private EducationalDepartmentDataSetTableAdapters.PlanContentTableAdapter planContentTableAdapter;
        private System.Windows.Forms.BindingSource planContentBindingSource;
        private EducationalDepartmentDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridView planContentDataGridView;
        private System.Windows.Forms.BindingSource plansBindingSource1;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanContentForm));
            this.educationalDepartmentDataSet = new DepartmentManager.EducationalDepartmentDataSet();
            this.plansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plansTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.PlansTableAdapter();
            this.tableAdapterManager = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.TableAdapterManager();
            this.planContentTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.PlanContentTableAdapter();
            this.subjectsTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.SubjectsTableAdapter();
            this.plansBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.planContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.plansBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.planContentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.plansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plansDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.educationalDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingNavigator)).BeginInit();
            this.plansBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planContentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // educationalDepartmentDataSet
            // 
            this.educationalDepartmentDataSet.DataSetName = "EducationalDepartmentDataSet";
            this.educationalDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plansBindingSource
            // 
            this.plansBindingSource.DataMember = "Plans";
            this.plansBindingSource.DataSource = this.educationalDepartmentDataSet;
            // 
            // plansTableAdapter
            // 
            this.plansTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.MarkRecordsTableAdapter = null;
            this.tableAdapterManager.PlanContentTableAdapter = this.planContentTableAdapter;
            this.tableAdapterManager.PlansTableAdapter = this.plansTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DepartmentManager.EducationalDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // planContentTableAdapter
            // 
            this.planContentTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // plansBindingNavigator
            // 
            this.plansBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plansBindingNavigator.BindingSource = this.planContentBindingSource;
            this.plansBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plansBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plansBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.plansBindingNavigatorSaveItem});
            this.plansBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.plansBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plansBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plansBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plansBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plansBindingNavigator.Name = "plansBindingNavigator";
            this.plansBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plansBindingNavigator.Size = new System.Drawing.Size(1078, 25);
            this.plansBindingNavigator.TabIndex = 0;
            this.plansBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // planContentBindingSource
            // 
            this.planContentBindingSource.DataMember = "FK_PlanContent_Plans";
            this.planContentBindingSource.DataSource = this.plansBindingSource;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // plansBindingNavigatorSaveItem
            // 
            this.plansBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plansBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plansBindingNavigatorSaveItem.Image")));
            this.plansBindingNavigatorSaveItem.Name = "plansBindingNavigatorSaveItem";
            this.plansBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.plansBindingNavigatorSaveItem.Text = "Save Data";
            this.plansBindingNavigatorSaveItem.Click += new System.EventHandler(this.PlansBindingNavigatorSaveItem_Click);
            // 
            // planContentDataGridView
            // 
            this.planContentDataGridView.AutoGenerateColumns = false;
            this.planContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planContentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1});
            this.planContentDataGridView.DataSource = this.planContentBindingSource;
            this.planContentDataGridView.Location = new System.Drawing.Point(12, 28);
            this.planContentDataGridView.Name = "planContentDataGridView";
            this.planContentDataGridView.Size = new System.Drawing.Size(757, 305);
            this.planContentDataGridView.TabIndex = 2;
            this.planContentDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.PlanContentDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlanId";
            this.dataGridViewTextBoxColumn2.DataSource = this.plansBindingSource1;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Speciality";
            this.dataGridViewTextBoxColumn2.HeaderText = "Специальность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // plansBindingSource1
            // 
            this.plansBindingSource1.DataMember = "Plans";
            this.plansBindingSource1.DataSource = this.educationalDepartmentDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectId";
            this.dataGridViewTextBoxColumn3.DataSource = this.subjectsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дисциплина";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.educationalDepartmentDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LectureDuration";
            this.dataGridViewTextBoxColumn4.HeaderText = "Лекции (ч)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LabDuration";
            this.dataGridViewTextBoxColumn5.HeaderText = "Лабораторные (ч)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CourseDuration";
            this.dataGridViewTextBoxColumn6.HeaderText = "Курсовые (ч)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // plansDataGridView
            // 
            this.plansDataGridView.AutoGenerateColumns = false;
            this.plansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7});
            this.plansDataGridView.DataSource = this.plansBindingSource;
            this.plansDataGridView.Location = new System.Drawing.Point(775, 28);
            this.plansDataGridView.Name = "plansDataGridView";
            this.plansDataGridView.Size = new System.Drawing.Size(289, 305);
            this.plansDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Speciality";
            this.dataGridViewTextBoxColumn8.HeaderText = "Специальность";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn9.HeaderText = "Год";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // PlanContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 348);
            this.Controls.Add(this.plansDataGridView);
            this.Controls.Add(this.planContentDataGridView);
            this.Controls.Add(this.plansBindingNavigator);
            this.Name = "PlanContentForm";
            this.Text = "План";
            this.Load += new System.EventHandler(this.PlanContentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.educationalDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingNavigator)).EndInit();
            this.plansBindingNavigator.ResumeLayout(false);
            this.plansBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planContentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView plansDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}