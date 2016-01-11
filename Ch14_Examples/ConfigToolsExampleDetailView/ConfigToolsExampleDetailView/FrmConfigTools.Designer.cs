namespace ConfigToolsExampleDetailView
{
    partial class FrmConfigTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigTools));
            System.Windows.Forms.Label student_IDLabel;
            System.Windows.Forms.Label student_FirstNameLabel;
            System.Windows.Forms.Label student_LastNameLabel;
            System.Windows.Forms.Label major_IDLabel;
            System.Windows.Forms.Label student_PhoneLabel;
            this.studentDataBaseDataSet = new ConfigToolsExampleDetailView.StudentDataBaseDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new ConfigToolsExampleDetailView.StudentDataBaseDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new ConfigToolsExampleDetailView.StudentDataBaseDataSetTableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.student_IDTextBox = new System.Windows.Forms.TextBox();
            this.student_FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.student_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.major_IDTextBox = new System.Windows.Forms.TextBox();
            this.student_PhoneTextBox = new System.Windows.Forms.TextBox();
            student_IDLabel = new System.Windows.Forms.Label();
            student_FirstNameLabel = new System.Windows.Forms.Label();
            student_LastNameLabel = new System.Windows.Forms.Label();
            major_IDLabel = new System.Windows.Forms.Label();
            student_PhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDataBaseDataSet
            // 
            this.studentDataBaseDataSet.DataSetName = "StudentDataBaseDataSet";
            this.studentDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDataBaseDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = ConfigToolsExampleDetailView.StudentDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(319, 25);
            this.studentBindingNavigator.TabIndex = 0;
            this.studentBindingNavigator.Text = "bindingNavigator1";
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
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click);
            // 
            // student_IDLabel
            // 
            student_IDLabel.AutoSize = true;
            student_IDLabel.Location = new System.Drawing.Point(23, 48);
            student_IDLabel.Name = "student_IDLabel";
            student_IDLabel.Size = new System.Drawing.Size(80, 18);
            student_IDLabel.TabIndex = 1;
            student_IDLabel.Text = "Student ID:";
            // 
            // student_IDTextBox
            // 
            this.student_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_ID", true));
            this.student_IDTextBox.Location = new System.Drawing.Point(166, 45);
            this.student_IDTextBox.Name = "student_IDTextBox";
            this.student_IDTextBox.Size = new System.Drawing.Size(100, 24);
            this.student_IDTextBox.TabIndex = 2;
            // 
            // student_FirstNameLabel
            // 
            student_FirstNameLabel.AutoSize = true;
            student_FirstNameLabel.Location = new System.Drawing.Point(23, 78);
            student_FirstNameLabel.Name = "student_FirstNameLabel";
            student_FirstNameLabel.Size = new System.Drawing.Size(139, 18);
            student_FirstNameLabel.TabIndex = 3;
            student_FirstNameLabel.Text = "Student First Name:";
            // 
            // student_FirstNameTextBox
            // 
            this.student_FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_FirstName", true));
            this.student_FirstNameTextBox.Location = new System.Drawing.Point(166, 75);
            this.student_FirstNameTextBox.Name = "student_FirstNameTextBox";
            this.student_FirstNameTextBox.Size = new System.Drawing.Size(100, 24);
            this.student_FirstNameTextBox.TabIndex = 4;
            // 
            // student_LastNameLabel
            // 
            student_LastNameLabel.AutoSize = true;
            student_LastNameLabel.Location = new System.Drawing.Point(23, 108);
            student_LastNameLabel.Name = "student_LastNameLabel";
            student_LastNameLabel.Size = new System.Drawing.Size(138, 18);
            student_LastNameLabel.TabIndex = 5;
            student_LastNameLabel.Text = "Student Last Name:";
            // 
            // student_LastNameTextBox
            // 
            this.student_LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_LastName", true));
            this.student_LastNameTextBox.Location = new System.Drawing.Point(166, 105);
            this.student_LastNameTextBox.Name = "student_LastNameTextBox";
            this.student_LastNameTextBox.Size = new System.Drawing.Size(100, 24);
            this.student_LastNameTextBox.TabIndex = 6;
            // 
            // major_IDLabel
            // 
            major_IDLabel.AutoSize = true;
            major_IDLabel.Location = new System.Drawing.Point(23, 138);
            major_IDLabel.Name = "major_IDLabel";
            major_IDLabel.Size = new System.Drawing.Size(50, 18);
            major_IDLabel.TabIndex = 7;
            major_IDLabel.Text = "Major:";
            // 
            // major_IDTextBox
            // 
            this.major_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "major_ID", true));
            this.major_IDTextBox.Location = new System.Drawing.Point(166, 135);
            this.major_IDTextBox.Name = "major_IDTextBox";
            this.major_IDTextBox.Size = new System.Drawing.Size(100, 24);
            this.major_IDTextBox.TabIndex = 8;
            // 
            // student_PhoneLabel
            // 
            student_PhoneLabel.AutoSize = true;
            student_PhoneLabel.Location = new System.Drawing.Point(23, 168);
            student_PhoneLabel.Name = "student_PhoneLabel";
            student_PhoneLabel.Size = new System.Drawing.Size(109, 18);
            student_PhoneLabel.TabIndex = 9;
            student_PhoneLabel.Text = "Student Phone:";
            // 
            // student_PhoneTextBox
            // 
            this.student_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_Phone", true));
            this.student_PhoneTextBox.Location = new System.Drawing.Point(166, 165);
            this.student_PhoneTextBox.Name = "student_PhoneTextBox";
            this.student_PhoneTextBox.Size = new System.Drawing.Size(100, 24);
            this.student_PhoneTextBox.TabIndex = 10;
            // 
            // FrmConfigTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(319, 239);
            this.Controls.Add(student_IDLabel);
            this.Controls.Add(this.student_IDTextBox);
            this.Controls.Add(student_FirstNameLabel);
            this.Controls.Add(this.student_FirstNameTextBox);
            this.Controls.Add(student_LastNameLabel);
            this.Controls.Add(this.student_LastNameTextBox);
            this.Controls.Add(major_IDLabel);
            this.Controls.Add(this.major_IDTextBox);
            this.Controls.Add(student_PhoneLabel);
            this.Controls.Add(this.student_PhoneTextBox);
            this.Controls.Add(this.studentBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConfigTools";
            this.Text = "Example using Configuration Tools";
            this.Load += new System.EventHandler(this.FrmConfigTools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataBaseDataSet studentDataBaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentDataBaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private StudentDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox student_IDTextBox;
        private System.Windows.Forms.TextBox student_FirstNameTextBox;
        private System.Windows.Forms.TextBox student_LastNameTextBox;
        private System.Windows.Forms.TextBox major_IDTextBox;
        private System.Windows.Forms.TextBox student_PhoneTextBox;
    }
}

