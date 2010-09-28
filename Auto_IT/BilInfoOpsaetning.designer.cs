namespace BilInfoSystem
{
    partial class BilInfoOpsaetning
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
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bilCheckBox1 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox2 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox3 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox10 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox4 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox9 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox5 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox8 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox6 = new System.Windows.Forms.CheckBox();
            this.bilCheckBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(57, 349);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(186, 349);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bilCheckBox1);
            this.groupBox3.Controls.Add(this.bilCheckBox2);
            this.groupBox3.Controls.Add(this.bilCheckBox3);
            this.groupBox3.Controls.Add(this.bilCheckBox10);
            this.groupBox3.Controls.Add(this.bilCheckBox4);
            this.groupBox3.Controls.Add(this.bilCheckBox9);
            this.groupBox3.Controls.Add(this.bilCheckBox5);
            this.groupBox3.Controls.Add(this.bilCheckBox8);
            this.groupBox3.Controls.Add(this.bilCheckBox6);
            this.groupBox3.Controls.Add(this.bilCheckBox7);
            this.groupBox3.Location = new System.Drawing.Point(34, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 181);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox1";
            // 
            // bilCheckBox1
            // 
            this.bilCheckBox1.AutoSize = true;
            this.bilCheckBox1.Location = new System.Drawing.Point(39, 46);
            this.bilCheckBox1.Name = "bilCheckBox1";
            this.bilCheckBox1.Size = new System.Drawing.Size(50, 17);
            this.bilCheckBox1.TabIndex = 0;
            this.bilCheckBox1.Text = "Type";
            this.bilCheckBox1.UseVisualStyleBackColor = true;
            this.bilCheckBox1.CheckedChanged += new System.EventHandler(this.bilCheckBox1_CheckedChanged);
            // 
            // bilCheckBox2
            // 
            this.bilCheckBox2.AutoSize = true;
            this.bilCheckBox2.Location = new System.Drawing.Point(39, 69);
            this.bilCheckBox2.Name = "bilCheckBox2";
            this.bilCheckBox2.Size = new System.Drawing.Size(79, 17);
            this.bilCheckBox2.TabIndex = 1;
            this.bilCheckBox2.Text = "Betegnelse";
            this.bilCheckBox2.UseVisualStyleBackColor = true;
            this.bilCheckBox2.CheckedChanged += new System.EventHandler(this.bilCheckBox2_CheckedChanged);
            // 
            // bilCheckBox3
            // 
            this.bilCheckBox3.AutoSize = true;
            this.bilCheckBox3.Location = new System.Drawing.Point(39, 93);
            this.bilCheckBox3.Name = "bilCheckBox3";
            this.bilCheckBox3.Size = new System.Drawing.Size(81, 17);
            this.bilCheckBox3.TabIndex = 2;
            this.bilCheckBox3.Text = "Stelnummer";
            this.bilCheckBox3.UseVisualStyleBackColor = true;
            this.bilCheckBox3.CheckedChanged += new System.EventHandler(this.bilCheckBox3_CheckedChanged);
            // 
            // bilCheckBox10
            // 
            this.bilCheckBox10.AutoSize = true;
            this.bilCheckBox10.Location = new System.Drawing.Point(173, 138);
            this.bilCheckBox10.Name = "bilCheckBox10";
            this.bilCheckBox10.Size = new System.Drawing.Size(164, 17);
            this.bilCheckBox10.TabIndex = 9;
            this.bilCheckBox10.Text = "Månedsdato for periodisk syn";
            this.bilCheckBox10.UseVisualStyleBackColor = true;
            this.bilCheckBox10.CheckedChanged += new System.EventHandler(this.bilCheckBox10_CheckedChanged);
            // 
            // bilCheckBox4
            // 
            this.bilCheckBox4.AutoSize = true;
            this.bilCheckBox4.Location = new System.Drawing.Point(39, 116);
            this.bilCheckBox4.Name = "bilCheckBox4";
            this.bilCheckBox4.Size = new System.Drawing.Size(128, 17);
            this.bilCheckBox4.TabIndex = 3;
            this.bilCheckBox4.Text = "Indregistreret til formål";
            this.bilCheckBox4.UseVisualStyleBackColor = true;
            this.bilCheckBox4.CheckedChanged += new System.EventHandler(this.bilCheckBox4_CheckedChanged);
            // 
            // bilCheckBox9
            // 
            this.bilCheckBox9.AutoSize = true;
            this.bilCheckBox9.Location = new System.Drawing.Point(173, 115);
            this.bilCheckBox9.Name = "bilCheckBox9";
            this.bilCheckBox9.Size = new System.Drawing.Size(133, 17);
            this.bilCheckBox9.TabIndex = 8;
            this.bilCheckBox9.Text = "Periodisk syn hvor ofte";
            this.bilCheckBox9.UseVisualStyleBackColor = true;
            this.bilCheckBox9.CheckedChanged += new System.EventHandler(this.bilCheckBox9_CheckedChanged);
            // 
            // bilCheckBox5
            // 
            this.bilCheckBox5.AutoSize = true;
            this.bilCheckBox5.Location = new System.Drawing.Point(39, 139);
            this.bilCheckBox5.Name = "bilCheckBox5";
            this.bilCheckBox5.Size = new System.Drawing.Size(130, 17);
            this.bilCheckBox5.TabIndex = 4;
            this.bilCheckBox5.Text = "Dato for 1. registrering";
            this.bilCheckBox5.UseVisualStyleBackColor = true;
            this.bilCheckBox5.CheckedChanged += new System.EventHandler(this.bilCheckBox5_CheckedChanged);
            // 
            // bilCheckBox8
            // 
            this.bilCheckBox8.AutoSize = true;
            this.bilCheckBox8.Location = new System.Drawing.Point(173, 92);
            this.bilCheckBox8.Name = "bilCheckBox8";
            this.bilCheckBox8.Size = new System.Drawing.Size(208, 17);
            this.bilCheckBox8.TabIndex = 7;
            this.bilCheckBox8.Text = "Dato for seneste godkendelse ved syn";
            this.bilCheckBox8.UseVisualStyleBackColor = true;
            this.bilCheckBox8.CheckedChanged += new System.EventHandler(this.bilCheckBox8_CheckedChanged);
            // 
            // bilCheckBox6
            // 
            this.bilCheckBox6.AutoSize = true;
            this.bilCheckBox6.Location = new System.Drawing.Point(173, 46);
            this.bilCheckBox6.Name = "bilCheckBox6";
            this.bilCheckBox6.Size = new System.Drawing.Size(194, 17);
            this.bilCheckBox6.TabIndex = 5;
            this.bilCheckBox6.Text = "Dato for seneste ind-/omregistrering";
            this.bilCheckBox6.UseVisualStyleBackColor = true;
            this.bilCheckBox6.CheckedChanged += new System.EventHandler(this.bilCheckBox6_CheckedChanged);
            // 
            // bilCheckBox7
            // 
            this.bilCheckBox7.AutoSize = true;
            this.bilCheckBox7.Location = new System.Drawing.Point(173, 69);
            this.bilCheckBox7.Name = "bilCheckBox7";
            this.bilCheckBox7.Size = new System.Drawing.Size(167, 17);
            this.bilCheckBox7.TabIndex = 6;
            this.bilCheckBox7.Text = "Dato for seneste afregistrering";
            this.bilCheckBox7.UseVisualStyleBackColor = true;
            this.bilCheckBox7.CheckedChanged += new System.EventHandler(this.bilCheckBox7_CheckedChanged);
            // 
            // BilInfoOpsaetning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "BilInfoOpsaetning";
            this.Text = "BilInfoOpsaetning";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox bilCheckBox1;
        private System.Windows.Forms.CheckBox bilCheckBox2;
        private System.Windows.Forms.CheckBox bilCheckBox3;
        private System.Windows.Forms.CheckBox bilCheckBox10;
        private System.Windows.Forms.CheckBox bilCheckBox4;
        private System.Windows.Forms.CheckBox bilCheckBox9;
        private System.Windows.Forms.CheckBox bilCheckBox5;
        private System.Windows.Forms.CheckBox bilCheckBox8;
        private System.Windows.Forms.CheckBox bilCheckBox6;
        private System.Windows.Forms.CheckBox bilCheckBox7;
    }
}