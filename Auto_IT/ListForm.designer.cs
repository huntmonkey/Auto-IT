namespace CRM_system
{
    partial class ListForm
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
            this.nummerpladeListbox = new System.Windows.Forms.ListBox();
            this.tilfojTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tilfojButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nummerpladeListbox
            // 
            this.nummerpladeListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummerpladeListbox.FormattingEnabled = true;
            this.nummerpladeListbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nummerpladeListbox.ItemHeight = 29;
            this.nummerpladeListbox.Location = new System.Drawing.Point(12, 54);
            this.nummerpladeListbox.Name = "nummerpladeListbox";
            this.nummerpladeListbox.Size = new System.Drawing.Size(281, 352);
            this.nummerpladeListbox.TabIndex = 8;
            this.nummerpladeListbox.TabStop = false;
            // 
            // tilfojTextbox
            // 
            this.tilfojTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilfojTextbox.Location = new System.Drawing.Point(29, 426);
            this.tilfojTextbox.Name = "tilfojTextbox";
            this.tilfojTextbox.Size = new System.Drawing.Size(133, 35);
            this.tilfojTextbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nummerplader";
            // 
            // tilfojButton
            // 
            this.tilfojButton.Location = new System.Drawing.Point(173, 424);
            this.tilfojButton.Name = "tilfojButton";
            this.tilfojButton.Size = new System.Drawing.Size(75, 37);
            this.tilfojButton.TabIndex = 9;
            this.tilfojButton.Text = "Tilføj";
            this.tilfojButton.UseVisualStyleBackColor = true;
            this.tilfojButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 36);
            this.panel2.TabIndex = 7;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 547);
            this.Controls.Add(this.nummerpladeListbox);
            this.Controls.Add(this.tilfojTextbox);
            this.Controls.Add(this.tilfojButton);
            this.Controls.Add(this.panel2);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nummerpladeListbox;
        private System.Windows.Forms.TextBox tilfojTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tilfojButton;
        private System.Windows.Forms.Panel panel2;
    }
}