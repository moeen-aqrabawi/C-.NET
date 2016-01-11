namespace PresentationGUI
{
    partial class PresentationGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnClub = new System.Windows.Forms.RadioButton();
            this.radBtnFratSor = new System.Windows.Forms.RadioButton();
            this.radBtnIntr = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFundedAmt = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxFund = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnClub);
            this.groupBox1.Controls.Add(this.radBtnFratSor);
            this.groupBox1.Controls.Add(this.radBtnIntr);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(75, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select organization type";
            // 
            // radBtnClub
            // 
            this.radBtnClub.AutoSize = true;
            this.radBtnClub.Location = new System.Drawing.Point(7, 80);
            this.radBtnClub.Name = "radBtnClub";
            this.radBtnClub.Size = new System.Drawing.Size(59, 24);
            this.radBtnClub.TabIndex = 2;
            this.radBtnClub.Text = "Club";
            this.radBtnClub.UseVisualStyleBackColor = true;
            this.radBtnClub.CheckedChanged += new System.EventHandler(this.radBtnClub_CheckedChanged);
            // 
            // radBtnFratSor
            // 
            this.radBtnFratSor.AutoSize = true;
            this.radBtnFratSor.Location = new System.Drawing.Point(7, 51);
            this.radBtnFratSor.Name = "radBtnFratSor";
            this.radBtnFratSor.Size = new System.Drawing.Size(152, 24);
            this.radBtnFratSor.TabIndex = 1;
            this.radBtnFratSor.Text = "Fraternity/Sorority";
            this.radBtnFratSor.UseVisualStyleBackColor = true;
            this.radBtnFratSor.CheckedChanged += new System.EventHandler(this.radBtnFratSor_CheckedChanged);
            // 
            // radBtnIntr
            // 
            this.radBtnIntr.AutoSize = true;
            this.radBtnIntr.Location = new System.Drawing.Point(7, 22);
            this.radBtnIntr.Name = "radBtnIntr";
            this.radBtnIntr.Size = new System.Drawing.Size(139, 24);
            this.radBtnIntr.TabIndex = 0;
            this.radBtnIntr.Text = "Intramural team";
            this.radBtnIntr.UseVisualStyleBackColor = true;
            this.radBtnIntr.CheckedChanged += new System.EventHandler(this.radBtnIntr_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 197);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            // 
            // lblFundedAmt
            // 
            this.lblFundedAmt.AutoSize = true;
            this.lblFundedAmt.Location = new System.Drawing.Point(36, 247);
            this.lblFundedAmt.Name = "lblFundedAmt";
            this.lblFundedAmt.Size = new System.Drawing.Size(104, 20);
            this.lblFundedAmt.TabIndex = 2;
            this.lblFundedAmt.Text = "Funding Amt:";
            this.lblFundedAmt.Visible = false;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(92, 197);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(223, 26);
            this.txtBxName.TabIndex = 3;
            this.txtBxName.Visible = false;
            // 
            // txtBxFund
            // 
            this.txtBxFund.Location = new System.Drawing.Point(141, 246);
            this.txtBxFund.Name = "txtBxFund";
            this.txtBxFund.Size = new System.Drawing.Size(105, 26);
            this.txtBxFund.TabIndex = 4;
            this.txtBxFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxFund.Visible = false;
            // 
            // PresentationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(351, 342);
            this.Controls.Add(this.txtBxFund);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblFundedAmt);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PresentationGUI";
            this.Text = "Student Government";
            this.Load += new System.EventHandler(this.PresentationGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnClub;
        private System.Windows.Forms.RadioButton radBtnFratSor;
        private System.Windows.Forms.RadioButton radBtnIntr;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFundedAmt;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxFund;
    }
}

