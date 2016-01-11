using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqDataBaseAccessExample
{
    public partial class FrmLinqExample : Form
    {
        public FrmLinqExample()
        {
            InitializeComponent();
        }

        private void memberTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.memberDataSet);

        }

        private void FrmLinqExample_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'memberDataSet.memberTable' table. You can move, or remove it, as needed.
            this.memberTableTableAdapter.Fill(this.memberDataSet.memberTable);

            var memberResults =
                  from member in this.memberDataSet.memberTable
                  where member.LastName.Length > 4
                  orderby member.LastName
                  select member;
            foreach (var aRecord in memberResults)
                this.lstBxResult.Items.Add(aRecord.FirstName + " " +
                       aRecord.LastName);
        }

    }
}
