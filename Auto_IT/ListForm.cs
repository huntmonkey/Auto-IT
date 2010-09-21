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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var nummerplade = tilfojTextbox.Text;
            nummerpladeListbox.Items.Insert(0, nummerplade);
            //Det efterfølgende text i metoden er ikke sikkert det skal være i denne classe, men en anden.
            //if(radiobutton.
            MessageBox.Show("Der er kommet en bil ind på parkeringspladsen.\n\n " +
                ""+nummerplade+" Ankomst kl. "+DateTime.Now.TimeOfDay.Hours+":"+DateTime.Now.TimeOfDay.Minutes, "Ny kunde",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
