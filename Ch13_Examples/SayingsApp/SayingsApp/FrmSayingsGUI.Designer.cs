namespace SayingsApp
{
    partial class FrmSayingsGUI
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
            this.txtBxSaying = new System.Windows.Forms.TextBox();
            this.btnStoreSaying = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Favorite Saying:";
            // 
            // txtBxSaying
            // 
            this.txtBxSaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSaying.Location = new System.Drawing.Point(87, 68);
            this.txtBxSaying.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSaying.Multiline = true;
            this.txtBxSaying.Name = "txtBxSaying";
            this.txtBxSaying.Size = new System.Drawing.Size(347, 136);
            this.txtBxSaying.TabIndex = 1;
            // 
            // btnStoreSaying
            // 
            this.btnStoreSaying.BackColor = System.Drawing.Color.Navy;
            this.btnStoreSaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreSaying.Location = new System.Drawing.Point(205, 231);
            this.btnStoreSaying.Margin = new System.Windows.Forms.Padding(4);
            this.btnStoreSaying.Name = "btnStoreSaying";
            this.btnStoreSaying.Size = new System.Drawing.Size(114, 62);
            this.btnStoreSaying.TabIndex = 2;
            this.btnStoreSaying.Text = "Store Saying";
            this.btnStoreSaying.UseVisualStyleBackColor = false;
            this.btnStoreSaying.Click += new System.EventHandler(this.btnStoreSaying_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(41, 332);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 24);
            this.lblMessage.TabIndex = 3;
            // 
            // FrmSayingsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(521, 484);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStoreSaying);
            this.Controls.Add(this.txtBxSaying);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSayingsGUI";
            this.Text = "Favorite Sayings Storing App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSayingsGUI_FormClosing);
            this.Load += new System.EventHandler(this.FrmSayingsGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxSaying;
        private System.Windows.Forms.Button btnStoreSaying;
        private System.Windows.Forms.Label lblMessage;
    }
}

