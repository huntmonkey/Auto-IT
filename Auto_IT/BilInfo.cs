using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilInfoSystem
{
    public partial class BilInfo : Form
    {
        BilInfoOpsaetning ps = new BilInfoOpsaetning(true, true, true, true, true, true, true, true, true, true);
        public BilInfo()
        {
            InitializeComponent();
            ps.AdviseParent += new BilInfoOpsaetning.AdviseParentEventHandler(setOpsaetning);
            ps.Show();
            ps.Visible = false;
        }

        public void setOpsaetning(Boolean ty, Boolean be, Boolean st, Boolean ind,
                                  Boolean da1, Boolean da2, Boolean da3, Boolean da4,
                                  Boolean pe, Boolean maa)
        {
            bilPanel1.Visible = ty;
            bilPanel2.Visible = be;
            bilPanel3.Visible = st;
            bilPanel4.Visible = ind;
            bilPanel5.Visible = da1;
            bilPanel6.Visible = da2;
            bilPanel7.Visible = da3;
            bilPanel8.Visible = da4;
            bilPanel9.Visible = pe;
            bilPanel10.Visible = maa;
        }

        private void opsætningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ps.Visible = true;
        }
    }
}
