namespace Rent_Calculator
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.btnComplete = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnCheckName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRentCost = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTill = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lPeriod = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAbsence = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.btnSaveRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComplete.Location = new System.Drawing.Point(90, 477);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(155, 23);
            this.btnComplete.TabIndex = 0;
            this.btnComplete.Text = "Done";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.Location = new System.Drawing.Point(106, 56);
            this.tbName.MaxLength = 12;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(122, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Who lives in your flat? (Press \"Enter\" or \"Add\" button\")";
            // 
            // btnAddName
            // 
            this.btnAddName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddName.Location = new System.Drawing.Point(234, 54);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(49, 23);
            this.btnAddName.TabIndex = 6;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnCheckName
            // 
            this.btnCheckName.Location = new System.Drawing.Point(35, 477);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(49, 23);
            this.btnCheckName.TabIndex = 7;
            this.btnCheckName.Text = "Check";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "How much does your rent cost?";
            // 
            // tbRentCost
            // 
            this.tbRentCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRentCost.Location = new System.Drawing.Point(106, 98);
            this.tbRentCost.MaxLength = 10;
            this.tbRentCost.Name = "tbRentCost";
            this.tbRentCost.Size = new System.Drawing.Size(122, 20);
            this.tbRentCost.TabIndex = 8;
            this.tbRentCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRentCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSaveRent_KeyDown);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFrom.Location = new System.Drawing.Point(98, 158);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(138, 20);
            this.dtpFrom.TabIndex = 10;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTill
            // 
            this.dtpTill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTill.Location = new System.Drawing.Point(98, 188);
            this.dtpTill.Name = "dtpTill";
            this.dtpTill.Size = new System.Drawing.Size(138, 20);
            this.dtpTill.TabIndex = 11;
            this.dtpTill.ValueChanged += new System.EventHandler(this.dtpTill_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "From (Inclusive)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Till (Exclusive)";
            // 
            // lPeriod
            // 
            this.lPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lPeriod.AutoSize = true;
            this.lPeriod.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lPeriod.Location = new System.Drawing.Point(116, 128);
            this.lPeriod.Name = "lPeriod";
            this.lPeriod.Size = new System.Drawing.Size(106, 13);
            this.lPeriod.TabIndex = 14;
            this.lPeriod.Text = "Time Period = 0 days";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(137, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "General Info";
            // 
            // labelAbsence
            // 
            this.labelAbsence.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAbsence.AutoSize = true;
            this.labelAbsence.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelAbsence.Location = new System.Drawing.Point(113, 223);
            this.labelAbsence.Name = "labelAbsence";
            this.labelAbsence.Size = new System.Drawing.Size(108, 13);
            this.labelAbsence.TabIndex = 16;
            this.labelAbsence.Text = "Absence Time (Days)";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.Location = new System.Drawing.Point(194, 249);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(30, 23);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = " X";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStart.Location = new System.Drawing.Point(76, 250);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(70, 20);
            this.lblStart.TabIndex = 19;
            this.lblStart.Text = "Invisible";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStart.Visible = false;
            // 
            // tbStart
            // 
            this.tbStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStart.Location = new System.Drawing.Point(147, 251);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(41, 20);
            this.tbStart.TabIndex = 20;
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStart.Visible = false;
            // 
            // btnSaveRent
            // 
            this.btnSaveRent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveRent.Location = new System.Drawing.Point(234, 96);
            this.btnSaveRent.Name = "btnSaveRent";
            this.btnSaveRent.Size = new System.Drawing.Size(49, 23);
            this.btnSaveRent.TabIndex = 21;
            this.btnSaveRent.Text = "Save";
            this.btnSaveRent.UseVisualStyleBackColor = true;
            this.btnSaveRent.Click += new System.EventHandler(this.btnSaveRent_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 512);
            this.Controls.Add(this.btnSaveRent);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelAbsence);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lPeriod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTill);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRentCost);
            this.Controls.Add(this.btnCheckName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnComplete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Calculator - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnCheckName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRentCost;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAbsence;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Button btnSaveRent;
    }
}