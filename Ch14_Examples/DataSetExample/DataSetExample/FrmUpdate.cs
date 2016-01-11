// DataSetExample.cs
// A Windows application is used as the 
// front end to display records retrieved
// from an Access database.
// Values can be changed and the
// database is updated using these changes.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataSetExample
{
    public partial class FrmUpdate : Form
    {
        private OleDbDataAdapter memberDataAdap;
        private DataSet memberDS;
        private OleDbCommandBuilder cBuilder;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConnection;
        private string sql;

        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cBuilder = new OleDbCommandBuilder(memberDataAdap);
                memberDataAdap.Update(memberDS, "memberTable");
            }
            catch (System.Exception exc)
            {
                this.lblMessage.Text = exc.Message;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                sConnection =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=member.accdb";
                dbConn = new OleDbConnection(sConnection);

                sql = "SELECT * FROM memberTable ORDER " +
                    "BY LastName ASC, FirstName ASC;";
                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                memberDataAdap = new OleDbDataAdapter();
                memberDataAdap.SelectCommand = dbCmd;
                memberDS = new DataSet();
                memberDataAdap.Fill(memberDS, "memberTable");
                dataGridView1.DataSource = memberDS;
                dataGridView1.DataMember = "memberTable";
            }
            catch (System.Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

 
    }
}
