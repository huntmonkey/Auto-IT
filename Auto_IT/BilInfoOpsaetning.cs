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
    public partial class BilInfoOpsaetning : Form
    {

        public Boolean type;
        public Boolean betegnelse;
        public Boolean stelnummer;
        public Boolean indregistrering;
        public Boolean dato1;
        public Boolean dato2;
        public Boolean dato3;
        public Boolean dato4;
        public Boolean periodisk;
        public Boolean maaned;

        public delegate void AdviseParentEventHandler(Boolean ty, Boolean be, Boolean st, Boolean ind,
                                                      Boolean da1, Boolean da2, Boolean da3, Boolean da4,
                                                      Boolean pe, Boolean maa);

        public event AdviseParentEventHandler AdviseParent;

        public BilInfoOpsaetning(bool type1, bool betegnelse2, bool stelnummer3, bool indregistrering4,
                                 bool dato5, bool dato6, bool dato7, bool dato8,
                                 bool periodisk9, bool maaned10)
        {
            InitializeComponent();
            bilCheckBox1.Checked = type1;
            type1 = type;
            bilCheckBox2.Checked = betegnelse2;
            betegnelse2 = betegnelse;
            bilCheckBox3.Checked = stelnummer3;
            stelnummer3 = stelnummer;
            bilCheckBox4.Checked = indregistrering4;
            indregistrering4 = indregistrering;
            bilCheckBox5.Checked = dato5;
            dato5 = dato1;
            bilCheckBox6.Checked = dato6;
            dato6 = dato2;
            bilCheckBox7.Checked = dato7;
            dato7 = dato3;
            bilCheckBox8.Checked = dato8;
            dato8 = dato4;
            bilCheckBox9.Checked = periodisk9;
            periodisk9 = periodisk;
            bilCheckBox10.Checked = maaned10;
            maaned10 = maaned;
        }

        public void setValg(Boolean ty, Boolean be, Boolean st, Boolean ind,
                            Boolean da1, Boolean da2, Boolean da3, Boolean da4,
                            Boolean pe, Boolean maa)
        {
            if (AdviseParent != null)
                AdviseParent(ty, be, st, ind, da1, da2, da3, da4, pe, maa);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            setValg(type, betegnelse, stelnummer, indregistrering, dato1, dato2, dato3, dato4, periodisk, maaned);
            this.Visible = false;
        }


        private void bilCheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            maaned = bilCheckBox10.Checked;
        }

        private void bilCheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            periodisk = bilCheckBox9.Checked;
        }

        private void bilCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            dato4 = bilCheckBox8.Checked;
        }

        private void bilCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            dato3 = bilCheckBox7.Checked;
        }

        private void bilCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            dato2 = bilCheckBox6.Checked;
        }

        private void bilCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            dato1 = bilCheckBox5.Checked;
        }

        private void bilCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            indregistrering = bilCheckBox4.Checked;
        }

        private void bilCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            stelnummer = bilCheckBox3.Checked;
        }

        private void bilCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            betegnelse = bilCheckBox2.Checked;
        }

        private void bilCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            type = bilCheckBox1.Checked;
        }
    }
}
