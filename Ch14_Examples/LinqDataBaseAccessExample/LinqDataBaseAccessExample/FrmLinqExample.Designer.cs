namespace LinqDataBaseAccessExample
{
    partial class FrmLinqExample
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
            this.memberDataSet = new LinqDataBaseAccessExample.memberDataSet();
            this.memberTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableTableAdapter = new LinqDataBaseAccessExample.memberDataSetTableAdapters.memberTableTableAdapter();
            this.tableAdapterManager = new LinqDataBaseAccessExample.memberDataSetTableAdapters.TableAdapterManager();
            this.lstBxResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberDataSet
            // 
            this.memberDataSet.DataSetName = "memberDataSet";
            this.memberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableBindingSource
            // 
            this.memberTableBindingSource.DataMember = "memberTable";
            this.memberTableBindingSource.DataSource = this.memberDataSet;
            // 
            // memberTableTableAdapter
            // 
            this.memberTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.memberTableTableAdapter = this.memberTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = LinqDataBaseAccessExample.memberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lstBxResult
            // 
            this.lstBxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxResult.FormattingEnabled = true;
            this.lstBxResult.ItemHeight = 18;
            this.lstBxResult.Location = new System.Drawing.Point(76, 25);
            this.lstBxResult.Name = "lstBxResult";
            this.lstBxResult.Size = new System.Drawing.Size(177, 148);
            this.lstBxResult.TabIndex = 1;
            // 
            // FrmLinqExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 245);
            this.Controls.Add(this.lstBxResult);
            this.Name = "FrmLinqExample";
            this.Text = "Linq Data Base Access Example...";
            this.Load += new System.EventHandler(this.FrmLinqExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private memberDataSet memberDataSet;
        private System.Windows.Forms.BindingSource memberTableBindingSource;
        private memberDataSetTableAdapters.memberTableTableAdapter memberTableTableAdapter;
        private memberDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox lstBxResult;

    }
}

