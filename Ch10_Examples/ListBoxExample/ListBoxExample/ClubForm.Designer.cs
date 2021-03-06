﻿/*  ClubForm.Designer.cs
 *  The code in the .Designer.cs file 
 *  is auto generated by Visual Studio.
 */
namespace ListBoxExample
{
    partial class ClubForm
    {
        // Required designer variable.
        private System.ComponentModel.IContainer 
            components = null;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        private void InitializeComponent()
        {
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBxEvents = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxAddNew = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(1, 356);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(475, 26);
            this.txtBxResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Event(s)";
            // 
            // lstBxEvents
            // 
            this.lstBxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstBxEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstBxEvents.FormattingEnabled = true;
            this.lstBxEvents.ItemHeight = 20;
            this.lstBxEvents.Items.AddRange(new object[] {
            "Amusement Park",
            "Boat Tour",
            "Dance",
            "Dinner",
            "Hike",
            "Movie",
            "Sport Event"});
            this.lstBxEvents.Location = new System.Drawing.Point(22, 58);
            this.lstBxEvents.Name = "lstBxEvents";
            this.lstBxEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxEvents.Size = new System.Drawing.Size(165, 124);
            this.lstBxEvents.Sorted = true;
            this.lstBxEvents.TabIndex = 1;
            this.lstBxEvents.SelectedIndexChanged += new System.EventHandler(this.lstBxEvents_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add an Activity";
            // 
            // txtBxAddNew
            // 
            this.txtBxAddNew.Location = new System.Drawing.Point(173, 224);
            this.txtBxAddNew.Name = "txtBxAddNew";
            this.txtBxAddNew.Size = new System.Drawing.Size(150, 26);
            this.txtBxAddNew.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(108, 268);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(128, 42);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Add New One";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ClubForm
            // 
            this.AcceptButton = this.btnNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(344, 403);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBxAddNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBxEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClubForm";
            this.Text = "Computer Club Outing Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBxEvents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxAddNew;
        private System.Windows.Forms.Button btnNew;

    }
}

