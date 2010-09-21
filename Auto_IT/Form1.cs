using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM_system
{
    public partial class Form1 : Form
    {
        ListForm list = new ListForm();
        bool popUp = true;
        KundeInfo.Opsaetning ps = new KundeInfo.Opsaetning(true, true, true, true, true, true, true, true, 
            true, true, true, true, true, true, true, true, true, true, true, 
            true, true); //skal indeholde true for så mange checkboxe der er. Skal vi bruge XML til at gemme ændringer???
        
        public Form1()
        {
            InitializeComponent();
            ps.AdviseParent += new KundeInfo.Opsaetning.AdviseParentEventHandler(setOpsaetning);
            ps.Show();
            ps.Visible = false;
        }

        private void setOpsaetning(Boolean ty, Boolean be, Boolean st, Boolean ind,
                                  Boolean da1, Boolean da2, Boolean da3, Boolean da4,
                                  Boolean pe, Boolean maa, Boolean na, Boolean ad, Boolean po, Boolean b,
                                  Boolean ma, Boolean cp, Boolean tl, Boolean mo,
                                  Boolean ar, Boolean cv, bool pu)
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
            kundePanel1.Visible = na;
            kundePanel2.Visible = ad;
            kundePanel3.Visible = po;
            kundePanel4.Visible = b;
            kundePanel5.Visible = ma;
            kundePanel6.Visible = cp;
            kundePanel7.Visible = tl;
            kundePanel8.Visible = mo;
            kundePanel9.Visible = ar;
            kundePanel10.Visible = cv;
            popUp = pu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nummerplade = tilfojTextbox.Text;
            nummerpladeListbox.Items.Insert(0, nummerplade);
            //Det efterfølgende text i metoden er ikke sikkert det skal være i denne classe, men en anden.
            if (popUp)
            {
                MessageBox.Show("Der er kommet en bil ind på parkeringspladsen.\n\n " +
                    "" + nummerplade + " Ankomst kl. " + DateTime.Now.TimeOfDay.Hours + ":" + DateTime.Now.TimeOfDay.Minutes, "Ny kunde", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void opsætningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ps.Visible = true;
        }

        private void afslutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
