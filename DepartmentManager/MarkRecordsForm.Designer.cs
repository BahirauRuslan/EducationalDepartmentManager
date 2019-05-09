﻿namespace DepartmentManager
{
    public partial class MarkRecordsForm
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
        private System.Windows.Forms.ComboBox plansComboBox;
        private EducationalDepartmentDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private EducationalDepartmentDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ComboBox groupsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EducationalDepartmentDataSetTableAdapters.PlanContentTableAdapter planContentTableAdapter;
        private System.Windows.Forms.ComboBox studentsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource planContentBindingSource;
        private EducationalDepartmentDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridView planContentDataGridView;
        private System.Windows.Forms.BindingSource plansBindingSource1;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private EducationalDepartmentDataSetTableAdapters.MarkRecordsTableAdapter markRecordsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource markRecordsBindingSource;
        private System.Windows.Forms.DataGridView markRecordsDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource planContentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkRecordsForm));
            this.educationalDepartmentDataSet = new DepartmentManager.EducationalDepartmentDataSet();
            this.plansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plansTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.PlansTableAdapter();
            this.tableAdapterManager = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.TableAdapterManager();
            this.plansBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.plansBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.plansComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.GroupsTableAdapter();
            this.groupsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.StudentsTableAdapter();
            this.studentsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.planContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planContentTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.PlanContentTableAdapter();
            this.planContentDataGridView = new System.Windows.Forms.DataGridView();
            this.plansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.SubjectsTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markRecordsTableAdapter = new DepartmentManager.EducationalDepartmentDataSetTableAdapters.MarkRecordsTableAdapter();
            this.markRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.planContentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.educationalDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingNavigator)).BeginInit();
            this.plansBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planContentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planContentBindingSource1)).BeginInit();
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
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.MarkRecordsTableAdapter = this.markRecordsTableAdapter;
            this.tableAdapterManager.PlanContentTableAdapter = this.planContentTableAdapter;
            this.tableAdapterManager.PlansTableAdapter = this.plansTableAdapter;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DepartmentManager.EducationalDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // plansBindingNavigator
            // 
            this.plansBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plansBindingNavigator.BindingSource = this.markRecordsBindingSource;
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
            this.plansBindingNavigator.Size = new System.Drawing.Size(1313, 25);
            this.plansBindingNavigator.TabIndex = 0;
            this.plansBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // plansBindingNavigatorSaveItem
            // 
            this.plansBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plansBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plansBindingNavigatorSaveItem.Image")));
            this.plansBindingNavigatorSaveItem.Name = "plansBindingNavigatorSaveItem";
            this.plansBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.plansBindingNavigatorSaveItem.Text = "Save Data";
            this.plansBindingNavigatorSaveItem.Click += new System.EventHandler(this.PlansBindingNavigatorSaveItem_Click);
            // 
            // plansComboBox
            // 
            this.plansComboBox.DataSource = this.plansBindingSource;
            this.plansComboBox.DisplayMember = "Speciality";
            this.plansComboBox.FormattingEnabled = true;
            this.plansComboBox.Location = new System.Drawing.Point(1088, 41);
            this.plansComboBox.Name = "plansComboBox";
            this.plansComboBox.Size = new System.Drawing.Size(205, 21);
            this.plansComboBox.TabIndex = 1;
            this.plansComboBox.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1085, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Специальность";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "FK_Groups_Plans";
            this.groupsBindingSource.DataSource = this.plansBindingSource;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsComboBox
            // 
            this.groupsComboBox.DataSource = this.groupsBindingSource;
            this.groupsComboBox.DisplayMember = "Number";
            this.groupsComboBox.FormattingEnabled = true;
            this.groupsComboBox.Location = new System.Drawing.Point(1088, 93);
            this.groupsComboBox.Name = "groupsComboBox";
            this.groupsComboBox.Size = new System.Drawing.Size(205, 21);
            this.groupsComboBox.TabIndex = 3;
            this.groupsComboBox.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1085, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Группа";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "FK_Students_Groups";
            this.studentsBindingSource.DataSource = this.groupsBindingSource;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.DataSource = this.studentsBindingSource;
            this.studentsComboBox.DisplayMember = "FullName";
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.Location = new System.Drawing.Point(1088, 147);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(205, 21);
            this.studentsComboBox.TabIndex = 5;
            this.studentsComboBox.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1085, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Студент";
            // 
            // planContentBindingSource
            // 
            this.planContentBindingSource.DataMember = "FK_PlanContent_Plans";
            this.planContentBindingSource.DataSource = this.plansBindingSource;
            // 
            // planContentTableAdapter
            // 
            this.planContentTableAdapter.ClearBeforeFill = true;
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
            this.planContentDataGridView.Location = new System.Drawing.Point(327, 25);
            this.planContentDataGridView.Name = "planContentDataGridView";
            this.planContentDataGridView.Size = new System.Drawing.Size(752, 421);
            this.planContentDataGridView.TabIndex = 7;
            // 
            // plansBindingSource1
            // 
            this.plansBindingSource1.DataMember = "Plans";
            this.plansBindingSource1.DataSource = this.educationalDepartmentDataSet;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.educationalDepartmentDataSet;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlanId";
            this.dataGridViewTextBoxColumn2.DataSource = this.plansBindingSource1;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Speciality";
            this.dataGridViewTextBoxColumn2.HeaderText = "Специальность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SubjectId";
            this.dataGridViewTextBoxColumn3.DataSource = this.subjectsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дисциплина";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LectureDuration";
            this.dataGridViewTextBoxColumn4.HeaderText = "Лекции (ч)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LabDuration";
            this.dataGridViewTextBoxColumn5.HeaderText = "Лабораторные (ч)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CourseDuration";
            this.dataGridViewTextBoxColumn6.HeaderText = "Курсовые (ч)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // markRecordsBindingSource
            // 
            this.markRecordsBindingSource.DataMember = "FK_MarkRecords_PlanContent";
            this.markRecordsBindingSource.DataSource = this.planContentBindingSource;
            // 
            // markRecordsTableAdapter
            // 
            this.markRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // markRecordsDataGridView
            // 
            this.markRecordsDataGridView.AutoGenerateColumns = false;
            this.markRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markRecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7});
            this.markRecordsDataGridView.DataSource = this.markRecordsBindingSource;
            this.markRecordsDataGridView.Location = new System.Drawing.Point(12, 25);
            this.markRecordsDataGridView.Name = "markRecordsDataGridView";
            this.markRecordsDataGridView.Size = new System.Drawing.Size(309, 421);
            this.markRecordsDataGridView.TabIndex = 8;
            // 
            // planContentBindingSource1
            // 
            this.planContentBindingSource1.DataMember = "PlanContent";
            this.planContentBindingSource1.DataSource = this.educationalDepartmentDataSet;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn8.DataSource = this.studentsBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "FullName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Студент";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Mark";
            this.dataGridViewTextBoxColumn10.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 85;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PlanContentId";
            this.dataGridViewTextBoxColumn9.DataSource = this.planContentBindingSource1;
            this.dataGridViewTextBoxColumn9.DisplayMember = "PlanId";
            this.dataGridViewTextBoxColumn9.HeaderText = "PlanContentId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "Id";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // MarkRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 458);
            this.Controls.Add(this.markRecordsDataGridView);
            this.Controls.Add(this.planContentDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plansComboBox);
            this.Controls.Add(this.plansBindingNavigator);
            this.Name = "MarkRecordsForm";
            this.Text = "Оценки";
            this.Load += new System.EventHandler(this.MarkRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.educationalDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingNavigator)).EndInit();
            this.plansBindingNavigator.ResumeLayout(false);
            this.plansBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planContentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plansBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markRecordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planContentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}