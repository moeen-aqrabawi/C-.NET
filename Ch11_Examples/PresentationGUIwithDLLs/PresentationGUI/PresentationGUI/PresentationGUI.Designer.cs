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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBxStudentSleep = new System.Windows.Forms.TextBox();
            this.txtBxPersonSleep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(146, 43);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(240, 26);
            this.txtBxName.TabIndex = 3;
            // 
            // txtBxAge
            // 
            this.txtBxAge.Location = new System.Drawing.Point(146, 100);
            this.txtBxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(55, 26);
            this.txtBxAge.TabIndex = 4;
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(146, 158);
            this.txtBxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(126, 26);
            this.txtBxID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sleep amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sleep amount for most people: ";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DarkBlue;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShow.Location = new System.Drawing.Point(149, 347);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(129, 38);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show Student";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtBxStudentSleep
            // 
            this.txtBxStudentSleep.Location = new System.Drawing.Point(292, 247);
            this.txtBxStudentSleep.Name = "txtBxStudentSleep";
            this.txtBxStudentSleep.Size = new System.Drawing.Size(74, 26);
            this.txtBxStudentSleep.TabIndex = 9;
            this.txtBxStudentSleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxPersonSleep
            // 
            this.txtBxPersonSleep.Location = new System.Drawing.Point(292, 287);
            this.txtBxPersonSleep.Name = "txtBxPersonSleep";
            this.txtBxPersonSleep.Size = new System.Drawing.Size(74, 26);
            this.txtBxPersonSleep.TabIndex = 10;
            this.txtBxPersonSleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PresentationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.txtBxPersonSleep);
            this.Controls.Add(this.txtBxStudentSleep);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PresentationGUI";
            this.Text = "Student Record";
            this.Load += new System.EventHandler(this.PresentationGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtBxStudentSleep;
        private System.Windows.Forms.TextBox txtBxPersonSleep;
    }
}

