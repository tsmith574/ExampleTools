namespace Tools
{
    partial class Manager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.rdoAddStaff = new System.Windows.Forms.RadioButton();
            this.rdoAddMan = new System.Windows.Forms.RadioButton();
            this.txtAddPass = new System.Windows.Forms.TextBox();
            this.txtAddUser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.chkItemsApproved = new System.Windows.Forms.CheckBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.rdoAddStaff);
            this.groupBox1.Controls.Add(this.rdoAddMan);
            this.groupBox1.Controls.Add(this.txtAddPass);
            this.groupBox1.Controls.Add(this.txtAddUser);
            this.groupBox1.Location = new System.Drawing.Point(41, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(210, 131);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // rdoAddStaff
            // 
            this.rdoAddStaff.AutoSize = true;
            this.rdoAddStaff.Location = new System.Drawing.Point(333, 95);
            this.rdoAddStaff.Name = "rdoAddStaff";
            this.rdoAddStaff.Size = new System.Drawing.Size(47, 17);
            this.rdoAddStaff.TabIndex = 3;
            this.rdoAddStaff.TabStop = true;
            this.rdoAddStaff.Text = "Staff";
            this.rdoAddStaff.UseVisualStyleBackColor = true;
            // 
            // rdoAddMan
            // 
            this.rdoAddMan.AutoSize = true;
            this.rdoAddMan.Location = new System.Drawing.Point(333, 52);
            this.rdoAddMan.Name = "rdoAddMan";
            this.rdoAddMan.Size = new System.Drawing.Size(67, 17);
            this.rdoAddMan.TabIndex = 2;
            this.rdoAddMan.TabStop = true;
            this.rdoAddMan.Text = "Manager";
            this.rdoAddMan.UseVisualStyleBackColor = true;
            // 
            // txtAddPass
            // 
            this.txtAddPass.Location = new System.Drawing.Point(120, 95);
            this.txtAddPass.Name = "txtAddPass";
            this.txtAddPass.Size = new System.Drawing.Size(141, 20);
            this.txtAddPass.TabIndex = 1;
            // 
            // txtAddUser
            // 
            this.txtAddUser.Location = new System.Drawing.Point(120, 51);
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.Size = new System.Drawing.Size(141, 20);
            this.txtAddUser.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNo);
            this.groupBox2.Controls.Add(this.btnApprove);
            this.groupBox2.Controls.Add(this.chkItemsApproved);
            this.groupBox2.Controls.Add(this.lstDisplay);
            this.groupBox2.Location = new System.Drawing.Point(41, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aprove Items taken out";
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(227, 119);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Yes";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // chkItemsApproved
            // 
            this.chkItemsApproved.AutoSize = true;
            this.chkItemsApproved.Location = new System.Drawing.Point(236, 41);
            this.chkItemsApproved.Name = "chkItemsApproved";
            this.chkItemsApproved.Size = new System.Drawing.Size(66, 17);
            this.chkItemsApproved.TabIndex = 1;
            this.chkItemsApproved.Text = "Approve";
            this.chkItemsApproved.UseVisualStyleBackColor = true;
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(18, 29);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(159, 134);
            this.lstDisplay.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(236, 78);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(91, 17);
            this.chkNo.TabIndex = 3;
            this.chkNo.Text = "Not approved";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.RadioButton rdoAddStaff;
        private System.Windows.Forms.RadioButton rdoAddMan;
        private System.Windows.Forms.TextBox txtAddPass;
        private System.Windows.Forms.TextBox txtAddUser;
        private System.Windows.Forms.CheckBox chkItemsApproved;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkNo;
    }
}