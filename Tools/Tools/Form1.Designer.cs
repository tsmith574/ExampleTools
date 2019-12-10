namespace Tools
{
    partial class Form1
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
            this.txtEquip = new System.Windows.Forms.TextBox();
            this.txtFeatures = new System.Windows.Forms.TextBox();
            this.rdoMal = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoKid = new System.Windows.Forms.RadioButton();
            this.rdoWorc = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstMalvern = new System.Windows.Forms.ListBox();
            this.lstReddtich = new System.Windows.Forms.ListBox();
            this.lstKidderminster = new System.Windows.Forms.ListBox();
            this.lstWorcester = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtRea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEquip
            // 
            this.txtEquip.Location = new System.Drawing.Point(199, 39);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(227, 20);
            this.txtEquip.TabIndex = 0;
            // 
            // txtFeatures
            // 
            this.txtFeatures.Location = new System.Drawing.Point(199, 95);
            this.txtFeatures.Name = "txtFeatures";
            this.txtFeatures.Size = new System.Drawing.Size(227, 20);
            this.txtFeatures.TabIndex = 1;
            // 
            // rdoMal
            // 
            this.rdoMal.AutoSize = true;
            this.rdoMal.Location = new System.Drawing.Point(83, 203);
            this.rdoMal.Name = "rdoMal";
            this.rdoMal.Size = new System.Drawing.Size(63, 17);
            this.rdoMal.TabIndex = 2;
            this.rdoMal.TabStop = true;
            this.rdoMal.Text = "Malvern";
            this.rdoMal.UseVisualStyleBackColor = true;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(190, 203);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(68, 17);
            this.rdoRed.TabIndex = 3;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Redditch";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // rdoKid
            // 
            this.rdoKid.AutoSize = true;
            this.rdoKid.Location = new System.Drawing.Point(317, 203);
            this.rdoKid.Name = "rdoKid";
            this.rdoKid.Size = new System.Drawing.Size(88, 17);
            this.rdoKid.TabIndex = 4;
            this.rdoKid.TabStop = true;
            this.rdoKid.Text = "Kidderminster";
            this.rdoKid.UseVisualStyleBackColor = true;
            // 
            // rdoWorc
            // 
            this.rdoWorc.AutoSize = true;
            this.rdoWorc.Location = new System.Drawing.Point(443, 203);
            this.rdoWorc.Name = "rdoWorc";
            this.rdoWorc.Size = new System.Drawing.Size(74, 17);
            this.rdoWorc.TabIndex = 5;
            this.rdoWorc.TabStop = true;
            this.rdoWorc.Text = "Worcester";
            this.rdoWorc.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstMalvern
            // 
            this.lstMalvern.FormattingEnabled = true;
            this.lstMalvern.Location = new System.Drawing.Point(69, 285);
            this.lstMalvern.Name = "lstMalvern";
            this.lstMalvern.Size = new System.Drawing.Size(213, 173);
            this.lstMalvern.TabIndex = 7;
            // 
            // lstReddtich
            // 
            this.lstReddtich.FormattingEnabled = true;
            this.lstReddtich.Location = new System.Drawing.Point(317, 285);
            this.lstReddtich.Name = "lstReddtich";
            this.lstReddtich.Size = new System.Drawing.Size(213, 173);
            this.lstReddtich.TabIndex = 8;
            // 
            // lstKidderminster
            // 
            this.lstKidderminster.FormattingEnabled = true;
            this.lstKidderminster.Location = new System.Drawing.Point(69, 466);
            this.lstKidderminster.Name = "lstKidderminster";
            this.lstKidderminster.Size = new System.Drawing.Size(213, 173);
            this.lstKidderminster.TabIndex = 9;
            // 
            // lstWorcester
            // 
            this.lstWorcester.FormattingEnabled = true;
            this.lstWorcester.Location = new System.Drawing.Point(317, 466);
            this.lstWorcester.Name = "lstWorcester";
            this.lstWorcester.Size = new System.Drawing.Size(213, 173);
            this.lstWorcester.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 672);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(351, 672);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Equipment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Features";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(266, 730);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 15;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtRea
            // 
            this.txtRea.Location = new System.Drawing.Point(154, 163);
            this.txtRea.Name = "txtRea";
            this.txtRea.Size = new System.Drawing.Size(323, 20);
            this.txtRea.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reason for use";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 775);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRea);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstWorcester);
            this.Controls.Add(this.lstKidderminster);
            this.Controls.Add(this.lstReddtich);
            this.Controls.Add(this.lstMalvern);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdoWorc);
            this.Controls.Add(this.rdoKid);
            this.Controls.Add(this.rdoRed);
            this.Controls.Add(this.rdoMal);
            this.Controls.Add(this.txtFeatures);
            this.Controls.Add(this.txtEquip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEquip;
        private System.Windows.Forms.TextBox txtFeatures;
        private System.Windows.Forms.RadioButton rdoMal;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoKid;
        private System.Windows.Forms.RadioButton rdoWorc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstMalvern;
        private System.Windows.Forms.ListBox lstReddtich;
        private System.Windows.Forms.ListBox lstKidderminster;
        private System.Windows.Forms.ListBox lstWorcester;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtRea;
        private System.Windows.Forms.Label label3;
    }
}

