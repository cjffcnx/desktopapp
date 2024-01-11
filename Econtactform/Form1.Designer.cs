namespace Econtactform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCrn = new System.Windows.Forms.Label();
            this.textboxCrn = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtboxContact = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lbldeposit = new System.Windows.Forms.Label();
            this.txtboxdeposit = new System.Windows.Forms.TextBox();
            this.txtboxwithdraw = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblwithdraw = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCrn
            // 
            this.lblCrn.AutoSize = true;
            this.lblCrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrn.Location = new System.Drawing.Point(88, 76);
            this.lblCrn.Name = "lblCrn";
            this.lblCrn.Size = new System.Drawing.Size(74, 25);
            this.lblCrn.TabIndex = 1;
            this.lblCrn.Text = "Crn No";
            // 
            // textboxCrn
            // 
            this.textboxCrn.Location = new System.Drawing.Point(267, 76);
            this.textboxCrn.Name = "textboxCrn";
            this.textboxCrn.ReadOnly = true;
            this.textboxCrn.Size = new System.Drawing.Size(235, 22);
            this.textboxCrn.TabIndex = 2;
            this.textboxCrn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(267, 194);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(235, 22);
            this.txtboxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(83, 194);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxContact
            // 
            this.txtboxContact.Location = new System.Drawing.Point(267, 256);
            this.txtboxContact.Name = "txtboxContact";
            this.txtboxContact.Size = new System.Drawing.Size(235, 22);
            this.txtboxContact.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(88, 335);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(267, 312);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(235, 80);
            this.txtboxAddress.TabIndex = 8;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(81, 256);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(110, 25);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact No";
            this.lblContact.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(267, 133);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(235, 22);
            this.txtboxFirstName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(85, 130);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(88, 421);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 25);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(267, 421);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(235, 24);
            this.cmbGender.TabIndex = 12;
            // 
            // lbldeposit
            // 
            this.lbldeposit.AutoSize = true;
            this.lbldeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeposit.Location = new System.Drawing.Point(83, 474);
            this.lbldeposit.Name = "lbldeposit";
            this.lbldeposit.Size = new System.Drawing.Size(139, 25);
            this.lbldeposit.TabIndex = 13;
            this.lbldeposit.Text = "Fee Submitted";
            // 
            // txtboxdeposit
            // 
            this.txtboxdeposit.Location = new System.Drawing.Point(267, 474);
            this.txtboxdeposit.Name = "txtboxdeposit";
            this.txtboxdeposit.Size = new System.Drawing.Size(235, 22);
            this.txtboxdeposit.TabIndex = 14;
            // 
            // txtboxwithdraw
            // 
            this.txtboxwithdraw.Location = new System.Drawing.Point(267, 532);
            this.txtboxwithdraw.Name = "txtboxwithdraw";
            this.txtboxwithdraw.Size = new System.Drawing.Size(235, 22);
            this.txtboxwithdraw.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(84, 601);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(190, 601);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 42);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(309, 601);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 42);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(427, 601);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 42);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Ivory;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "Student Management System";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Linen;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(528, 76);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 25);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search";
            // 
            // lblwithdraw
            // 
            this.lblwithdraw.AutoSize = true;
            this.lblwithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwithdraw.Location = new System.Drawing.Point(79, 532);
            this.lblwithdraw.Name = "lblwithdraw";
            this.lblwithdraw.Size = new System.Drawing.Size(177, 25);
            this.lblwithdraw.TabIndex = 23;
            this.lblwithdraw.Text = "Remaining Amount";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(621, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(318, 22);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1235, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(533, 130);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RowHeadersWidth = 51;
            this.dgvContactList.RowTemplate.Height = 24;
            this.dgvContactList.Size = new System.Drawing.Size(722, 513);
            this.dgvContactList.TabIndex = 26;
            this.dgvContactList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactList_CellContentClick);
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_RowHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 702);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblwithdraw);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxwithdraw);
            this.Controls.Add(this.txtboxdeposit);
            this.Controls.Add(this.lbldeposit);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtboxContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.textboxCrn);
            this.Controls.Add(this.lblCrn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Econtact";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCrn;
        private System.Windows.Forms.TextBox textboxCrn;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtboxContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lbldeposit;
        private System.Windows.Forms.TextBox txtboxdeposit;
        private System.Windows.Forms.TextBox txtboxwithdraw;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblwithdraw;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvContactList;
    }
}

