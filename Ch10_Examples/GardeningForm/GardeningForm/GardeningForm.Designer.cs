namespace GardeningForm
{
    partial class GardeningForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lstBxTrees = new System.Windows.Forms.ListBox();
            this.cmboFlowers = new System.Windows.Forms.ComboBox();
            this.lblFlower = new System.Windows.Forms.Label();
            this.lblTrees = new System.Windows.Forms.Label();
            this.lblFlowerAnswer = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.txtBxResultFlowers = new System.Windows.Forms.TextBox();
            this.txtBxResultTrees = new System.Windows.Forms.TextBox();
            this.lblTreeAnswer = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOutput = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(113, 30);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(200, 26);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Mark your selection";
            // 
            // lstBxTrees
            // 
            this.lstBxTrees.FormattingEnabled = true;
            this.lstBxTrees.ItemHeight = 20;
            this.lstBxTrees.Items.AddRange(new object[] {
            "Maple",
            "Oak",
            "Palm",
            "Pine",
            "Spruce",
            "Walnut"});
            this.lstBxTrees.Location = new System.Drawing.Point(219, 95);
            this.lstBxTrees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBxTrees.Name = "lstBxTrees";
            this.lstBxTrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxTrees.Size = new System.Drawing.Size(178, 84);
            this.lstBxTrees.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lstBxTrees, "Press and Hold the Ctrl Key for Multiple Selections!");
            this.lstBxTrees.SelectedIndexChanged += new System.EventHandler(this.lstBxTrees_SelectedIndexChanged);
            // 
            // cmboFlowers
            // 
            this.cmboFlowers.FormattingEnabled = true;
            this.cmboFlowers.Items.AddRange(new object[] {
            "Roses",
            "Orchids",
            "Tulips",
            "Daisies",
            "Asters",
            "Mums"});
            this.cmboFlowers.Location = new System.Drawing.Point(27, 95);
            this.cmboFlowers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboFlowers.Name = "cmboFlowers";
            this.cmboFlowers.Size = new System.Drawing.Size(180, 28);
            this.cmboFlowers.TabIndex = 2;
            this.cmboFlowers.SelectedIndexChanged += new System.EventHandler(this.cmboFlowers_SelectedIndexChanged);
            this.cmboFlowers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmboFlowers_KeyPress);
            // 
            // lblFlower
            // 
            this.lblFlower.AutoSize = true;
            this.lblFlower.Location = new System.Drawing.Point(79, 71);
            this.lblFlower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlower.Name = "lblFlower";
            this.lblFlower.Size = new System.Drawing.Size(64, 20);
            this.lblFlower.TabIndex = 3;
            this.lblFlower.Text = "Flowers";
            // 
            // lblTrees
            // 
            this.lblTrees.AutoSize = true;
            this.lblTrees.Location = new System.Drawing.Point(286, 71);
            this.lblTrees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrees.Name = "lblTrees";
            this.lblTrees.Size = new System.Drawing.Size(49, 20);
            this.lblTrees.TabIndex = 4;
            this.lblTrees.Text = "Trees";
            // 
            // lblFlowerAnswer
            // 
            this.lblFlowerAnswer.AutoSize = true;
            this.lblFlowerAnswer.Location = new System.Drawing.Point(46, 273);
            this.lblFlowerAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlowerAnswer.Name = "lblFlowerAnswer";
            this.lblFlowerAnswer.Size = new System.Drawing.Size(137, 20);
            this.lblFlowerAnswer.TabIndex = 5;
            this.lblFlowerAnswer.Text = "Flower preference";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // txtBxResultFlowers
            // 
            this.txtBxResultFlowers.Location = new System.Drawing.Point(26, 302);
            this.txtBxResultFlowers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxResultFlowers.Name = "txtBxResultFlowers";
            this.txtBxResultFlowers.Size = new System.Drawing.Size(181, 26);
            this.txtBxResultFlowers.TabIndex = 6;
            // 
            // txtBxResultTrees
            // 
            this.txtBxResultTrees.Location = new System.Drawing.Point(218, 242);
            this.txtBxResultTrees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxResultTrees.Multiline = true;
            this.txtBxResultTrees.Name = "txtBxResultTrees";
            this.txtBxResultTrees.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBxResultTrees.Size = new System.Drawing.Size(179, 86);
            this.txtBxResultTrees.TabIndex = 7;
            // 
            // lblTreeAnswer
            // 
            this.lblTreeAnswer.AutoSize = true;
            this.lblTreeAnswer.Location = new System.Drawing.Point(242, 215);
            this.lblTreeAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTreeAnswer.Name = "lblTreeAnswer";
            this.lblTreeAnswer.Size = new System.Drawing.Size(130, 20);
            this.lblTreeAnswer.TabIndex = 8;
            this.lblTreeAnswer.Text = "Tree preferences";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuFormat,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(92, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFont,
            this.menuColor});
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(57, 20);
            this.menuFormat.Text = "F&ormat";
            // 
            // menuFont
            // 
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(103, 22);
            this.menuFont.Text = "Font";
            this.menuFont.Click += new System.EventHandler(this.menuFont_Click);
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(103, 22);
            this.menuColor.Text = "Color";
            this.menuColor.Click += new System.EventHandler(this.menuColor_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(107, 22);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(50, 348);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(85, 20);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Add water!";
            // 
            // GardeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblTreeAnswer);
            this.Controls.Add(this.txtBxResultTrees);
            this.Controls.Add(this.txtBxResultFlowers);
            this.Controls.Add(this.lblFlowerAnswer);
            this.Controls.Add(this.lblTrees);
            this.Controls.Add(this.lblFlower);
            this.Controls.Add(this.cmboFlowers);
            this.Controls.Add(this.lstBxTrees);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GardeningForm";
            this.Text = "Gardening Guide";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox lstBxTrees;
        private System.Windows.Forms.ComboBox cmboFlowers;
        private System.Windows.Forms.Label lblFlower;
        private System.Windows.Forms.Label lblTrees;
        private System.Windows.Forms.Label lblFlowerAnswer;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox txtBxResultFlowers;
        private System.Windows.Forms.TextBox txtBxResultTrees;
        private System.Windows.Forms.Label lblTreeAnswer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStripMenuItem menuFont;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
    }
}

