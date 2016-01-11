namespace GUIControls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( Form1 ) );
            this.label1 = new System.Windows.Forms.Label ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.textBox1 = new System.Windows.Forms.TextBox ( );
            this.textBox2 = new System.Windows.Forms.TextBox ( );
            this.lstBoxEvents = new System.Windows.Forms.ListBox ( );
            this.checkBox1 = new System.Windows.Forms.CheckBox ( );
            this.checkBox2 = new System.Windows.Forms.CheckBox ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.radioButton1 = new System.Windows.Forms.RadioButton ( );
            this.radioButton2 = new System.Windows.Forms.RadioButton ( );
            this.comboBox1 = new System.Windows.Forms.ComboBox ( );
            this.pictureBox1 = new System.Windows.Forms.PictureBox ( );
            this.button1 = new System.Windows.Forms.Button ( );
            this.groupBox1.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point ( 58, -1 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size ( 142, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Label -- identify other objects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point ( 68, 12 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size ( 123, 13 );
            this.label2.TabIndex = 1;
            this.label2.Text = "Label -- display read only";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point ( 2, 37 );
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size ( 160, 20 );
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "TextBox -- used for data entry";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Navy;
            this.textBox2.Location = new System.Drawing.Point ( 2, 63 );
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size ( 160, 20 );
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "TextBox -- used to display text";
            // 
            // lstBoxEvents
            // 
            this.lstBoxEvents.BackColor = System.Drawing.Color.White;
            this.lstBoxEvents.ForeColor = System.Drawing.Color.FromArgb ( ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))) );
            this.lstBoxEvents.FormattingEnabled = true;
            this.lstBoxEvents.Items.AddRange ( new object[ ] {
            "ListBox---------------",
            "holds",
            "list of items from",
            "which user can ",
            "select"} );
            this.lstBoxEvents.Location = new System.Drawing.Point ( 2, 89 );
            this.lstBoxEvents.Name = "lstBoxEvents";
            this.lstBoxEvents.ScrollAlwaysVisible = true;
            this.lstBoxEvents.Size = new System.Drawing.Size ( 117, 69 );
            this.lstBoxEvents.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point ( 166, 89 );
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size ( 121, 17 );
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "CheckBox - Yes/No";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point ( 166, 112 );
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size ( 121, 17 );
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "CheckBox - Yes/No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add ( this.radioButton2 );
            this.groupBox1.Controls.Add ( this.radioButton1 );
            this.groupBox1.Location = new System.Drawing.Point ( 2, 164 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size ( 135, 62 );
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GroupBox -- Select one";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point ( 0, 20 );
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size ( 93, 17 );
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Radio Button1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point ( 0, 43 );
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size ( 93, 17 );
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Radio Button1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange ( new object[ ] {
            "Pick me",
            "No pick me"} );
            this.comboBox1.Location = new System.Drawing.Point ( 3, 231 );
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size ( 145, 21 );
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "ComboBox -- Select one";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject ( "pictureBox1.Image" )));
            this.pictureBox1.Location = new System.Drawing.Point ( 154, 135 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size ( 135, 103 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point ( 189, 244 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size ( 75, 23 );
            this.button1.TabIndex = 10;
            this.button1.Text = "Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb ( ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))) );
            this.ClientSize = new System.Drawing.Size ( 292, 273 );
            this.Controls.Add ( this.button1 );
            this.Controls.Add ( this.pictureBox1 );
            this.Controls.Add ( this.comboBox1 );
            this.Controls.Add ( this.groupBox1 );
            this.Controls.Add ( this.checkBox2 );
            this.Controls.Add ( this.checkBox1 );
            this.Controls.Add ( this.lstBoxEvents );
            this.Controls.Add ( this.textBox2 );
            this.Controls.Add ( this.textBox1 );
            this.Controls.Add ( this.label2 );
            this.Controls.Add ( this.label1 );
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form1";
            this.Text = "Basic user interface control objects";
            this.groupBox1.ResumeLayout ( false );
            this.groupBox1.PerformLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit ( );
            this.ResumeLayout ( false );
            this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lstBoxEvents;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

