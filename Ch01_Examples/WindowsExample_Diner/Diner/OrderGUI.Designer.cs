using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Diner
{
    partial class OrderGUI : Form
    {
        private Order newOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxEntree;
        private System.Windows.Forms.ComboBox cmboBoxSpecial;
        private System.Windows.Forms.CheckBox ckBoxWater;
        private System.Windows.Forms.RadioButton radCoffee;
        private System.Windows.Forms.RadioButton radTea;
        private System.Windows.Forms.RadioButton radLemon;
        private System.Windows.Forms.RadioButton radSoda;
        private System.Windows.Forms.RadioButton radJuice;
        private System.Windows.Forms.RadioButton radMilk;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuPlaceOrder;
        private ToolStripMenuItem menuClearOrder;
        private ToolStripMenuItem menuDisplayOrder;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem menuEditEntree;
        private ToolStripMenuItem menuEditDrink;
        private ToolStripMenuItem menuEditSpecial;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem menuAbout;
        private System.ComponentModel.IContainer components = null;
      
        //public OrderGUI( )
        //{
        //    InitializeComponent( );
        //}
        protected override void Dispose( bool disposing )
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose( );
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderGUI));
            this.lstBoxEntree = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCoffee = new System.Windows.Forms.RadioButton();
            this.radTea = new System.Windows.Forms.RadioButton();
            this.radLemon = new System.Windows.Forms.RadioButton();
            this.radSoda = new System.Windows.Forms.RadioButton();
            this.radJuice = new System.Windows.Forms.RadioButton();
            this.radMilk = new System.Windows.Forms.RadioButton();
            this.cmboBoxSpecial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckBoxWater = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlaceOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplayOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditEntree = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditDrink = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxEntree
            // 
            this.lstBoxEntree.BackColor = System.Drawing.Color.Khaki;
            this.lstBoxEntree.ItemHeight = 16;
            this.lstBoxEntree.Location = new System.Drawing.Point(23, 59);
            this.lstBoxEntree.Name = "lstBoxEntree";
            this.lstBoxEntree.Size = new System.Drawing.Size(156, 68);
            this.lstBoxEntree.TabIndex = 0;
            this.lstBoxEntree.SelectedIndexChanged += new System.EventHandler(this.lstBoxEntree_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entree Selection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCoffee);
            this.groupBox2.Controls.Add(this.radTea);
            this.groupBox2.Controls.Add(this.radLemon);
            this.groupBox2.Controls.Add(this.radSoda);
            this.groupBox2.Controls.Add(this.radJuice);
            this.groupBox2.Controls.Add(this.radMilk);
            this.groupBox2.Location = new System.Drawing.Point(205, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 176);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drink Selection";
            // 
            // radCoffee
            // 
            this.radCoffee.Location = new System.Drawing.Point(8, 144);
            this.radCoffee.Name = "radCoffee";
            this.radCoffee.Size = new System.Drawing.Size(104, 24);
            this.radCoffee.TabIndex = 5;
            this.radCoffee.Text = "Coffee";
            this.radCoffee.CheckedChanged += new System.EventHandler(this.Drink_CheckedChanged);
            // 
            // radTea
            // 
            this.radTea.Location = new System.Drawing.Point(8, 120);
            this.radTea.Name = "radTea";
            this.radTea.Size = new System.Drawing.Size(104, 24);
            this.radTea.TabIndex = 4;
            this.radTea.Text = "Tea";
            this.radTea.CheckedChanged += new System.EventHandler(this.Drink_CheckedChanged);
            // 
            // radLemon
            // 
            this.radLemon.Location = new System.Drawing.Point(8, 96);
            this.radLemon.Name = "radLemon";
            this.radLemon.Size = new System.Drawing.Size(104, 24);
            this.radLemon.TabIndex = 3;
            this.radLemon.Text = "Lemonade";
            this.radLemon.CheckedChanged += new System.EventHandler(this.Drink_CheckedChanged);
            // 
            // radSoda
            // 
            this.radSoda.Location = new System.Drawing.Point(8, 72);
            this.radSoda.Name = "radSoda";
            this.radSoda.Size = new System.Drawing.Size(104, 24);
            this.radSoda.TabIndex = 2;
            this.radSoda.Text = "Soda";
            this.radSoda.CheckedChanged += new System.EventHandler(this.Drink_CheckedChanged);
            // 
            // radJuice
            // 
            this.radJuice.Location = new System.Drawing.Point(8, 48);
            this.radJuice.Name = "radJuice";
            this.radJuice.Size = new System.Drawing.Size(104, 24);
            this.radJuice.TabIndex = 1;
            this.radJuice.Text = "Juice";
            this.radJuice.CheckedChanged += new System.EventHandler(this.Drink_CheckedChanged);
            // 
            // radMilk
            // 
            this.radMilk.Location = new System.Drawing.Point(8, 24);
            this.radMilk.Name = "radMilk";
            this.radMilk.Size = new System.Drawing.Size(104, 24);
            this.radMilk.TabIndex = 0;
            this.radMilk.Text = "Milk";
            this.radMilk.CheckedChanged += new System.EventHandler(this.Drink_CheckedChanged);
            // 
            // cmboBoxSpecial
            // 
            this.cmboBoxSpecial.BackColor = System.Drawing.Color.Khaki;
            this.cmboBoxSpecial.Items.AddRange(new object[] {
            "Whole Wheat",
            "Pumpernickel",
            "Seedless Rye",
            "Pita",
            "Sour Dough"});
            this.cmboBoxSpecial.Location = new System.Drawing.Point(23, 170);
            this.cmboBoxSpecial.Name = "cmboBoxSpecial";
            this.cmboBoxSpecial.Size = new System.Drawing.Size(168, 24);
            this.cmboBoxSpecial.TabIndex = 4;
            this.cmboBoxSpecial.SelectedIndexChanged += new System.EventHandler(this.cmboBoxSpecial_SelectedIndexChanged);
            this.cmboBoxSpecial.TextChanged += new System.EventHandler(this.cmboBoxSpecial_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Special Requests";
            // 
            // ckBoxWater
            // 
            this.ckBoxWater.Location = new System.Drawing.Point(69, 210);
            this.ckBoxWater.Name = "ckBoxWater";
            this.ckBoxWater.Size = new System.Drawing.Size(64, 24);
            this.ckBoxWater.TabIndex = 6;
            this.ckBoxWater.Text = "Water";
            this.ckBoxWater.CheckedChanged += new System.EventHandler(this.ckBoxWater_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlaceOrder,
            this.menuClearOrder,
            this.menuDisplayOrder,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuPlaceOrder
            // 
            this.menuPlaceOrder.Name = "menuPlaceOrder";
            this.menuPlaceOrder.Size = new System.Drawing.Size(145, 22);
            this.menuPlaceOrder.Text = "Place Order";
            this.menuPlaceOrder.Click += new System.EventHandler(this.menuPlaceOrder_Click);
            // 
            // menuClearOrder
            // 
            this.menuClearOrder.Name = "menuClearOrder";
            this.menuClearOrder.Size = new System.Drawing.Size(145, 22);
            this.menuClearOrder.Text = "Clear Order";
            this.menuClearOrder.Click += new System.EventHandler(this.menuClearOrder_Click);
            // 
            // menuDisplayOrder
            // 
            this.menuDisplayOrder.Name = "menuDisplayOrder";
            this.menuDisplayOrder.Size = new System.Drawing.Size(145, 22);
            this.menuDisplayOrder.Text = "Display Order";
            this.menuDisplayOrder.Click += new System.EventHandler(this.menuDisplayOrder_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(145, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditEntree,
            this.menuEditDrink,
            this.menuEditSpecial});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // menuEditEntree
            // 
            this.menuEditEntree.Name = "menuEditEntree";
            this.menuEditEntree.Size = new System.Drawing.Size(161, 22);
            this.menuEditEntree.Text = "Entree";
            this.menuEditEntree.Click += new System.EventHandler(this.menuEditEntree_Click);
            // 
            // menuEditDrink
            // 
            this.menuEditDrink.Name = "menuEditDrink";
            this.menuEditDrink.Size = new System.Drawing.Size(161, 22);
            this.menuEditDrink.Text = "Drink";
            this.menuEditDrink.Click += new System.EventHandler(this.menuEditDrink_Click);
            // 
            // menuEditSpecial
            // 
            this.menuEditSpecial.Name = "menuEditSpecial";
            this.menuEditSpecial.Size = new System.Drawing.Size(161, 22);
            this.menuEditSpecial.Text = "Special Requests";
            this.menuEditSpecial.Click += new System.EventHandler(this.menuEditSpecial_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(107, 22);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // OrderGUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(342, 253);
            this.Controls.Add(this.ckBoxWater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboBoxSpecial);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxEntree);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderGUI";
            this.Text = "Student Union   -   Diner by the Valley";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}

