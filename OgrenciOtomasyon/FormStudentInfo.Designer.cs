
namespace OgrenciOtomasyon
{
    partial class FormStudentInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lblMidterm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciler1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsDataSet = new OgrenciOtomasyon.obsDataSet();
            this.ogrenciler1TableAdapter = new OgrenciOtomasyon.obsDataSetTableAdapters.ogrenciler1TableAdapter();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxContact = new System.Windows.Forms.TextBox();
            this.txtBoxGender = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.exam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciler1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMidterm
            // 
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.BackColor = System.Drawing.Color.Transparent;
            this.lblMidterm.Location = new System.Drawing.Point(54, 243);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(60, 17);
            this.lblMidterm.TabIndex = 98;
            this.lblMidterm.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(53, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "Gender:";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.BackColor = System.Drawing.Color.Transparent;
            this.lblNumara.Location = new System.Drawing.Point(55, 215);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(78, 17);
            this.lblNumara.TabIndex = 91;
            this.lblNumara.Text = "Student ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(53, 149);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 89;
            this.lblFirstName.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 67);
            this.label3.TabIndex = 85;
            this.label3.Text = "Bilgi School Student Panel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1251, 82);
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(931, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 64);
            this.btnExit.TabIndex = 101;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.numaraDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.vizeDataGridViewTextBoxColumn,
            this.finalDataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciler1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1057, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(266, 81);
            this.dataGridView1.TabIndex = 103;
            this.dataGridView1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "numara";
            this.numaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            this.numaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "program";
            this.programDataGridViewTextBoxColumn.HeaderText = "program";
            this.programDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            this.programDataGridViewTextBoxColumn.Width = 125;
            // 
            // vizeDataGridViewTextBoxColumn
            // 
            this.vizeDataGridViewTextBoxColumn.DataPropertyName = "vize";
            this.vizeDataGridViewTextBoxColumn.HeaderText = "vize";
            this.vizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vizeDataGridViewTextBoxColumn.Name = "vizeDataGridViewTextBoxColumn";
            this.vizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalDataGridViewTextBoxColumn
            // 
            this.finalDataGridViewTextBoxColumn.DataPropertyName = "final";
            this.finalDataGridViewTextBoxColumn.HeaderText = "final";
            this.finalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalDataGridViewTextBoxColumn.Name = "finalDataGridViewTextBoxColumn";
            this.finalDataGridViewTextBoxColumn.Width = 125;
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            this.ortalamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciler1BindingSource
            // 
            this.ogrenciler1BindingSource.DataMember = "ogrenciler1";
            this.ogrenciler1BindingSource.DataSource = this.obsDataSet;
            // 
            // obsDataSet
            // 
            this.obsDataSet.DataSetName = "obsDataSet";
            this.obsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciler1TableAdapter
            // 
            this.ogrenciler1TableAdapter.ClearBeforeFill = true;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentNumber.Location = new System.Drawing.Point(1106, 83);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(107, 17);
            this.lblStudentNumber.TabIndex = 104;
            this.lblStudentNumber.Text = "StudentNumber";
            this.lblStudentNumber.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(53, 182);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 17);
            this.lblLastName.TabIndex = 106;
            this.lblLastName.Text = "Last name:";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.BackColor = System.Drawing.Color.Transparent;
            this.lblNationality.Location = new System.Drawing.Point(53, 314);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(64, 17);
            this.lblNationality.TabIndex = 107;
            this.lblNationality.Text = "Address:";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(178, 144);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.ReadOnly = true;
            this.txtBoxFirstName.Size = new System.Drawing.Size(229, 22);
            this.txtBoxFirstName.TabIndex = 115;
            this.txtBoxFirstName.TextChanged += new System.EventHandler(this.FormStudentInfo_Load);
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(178, 179);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.ReadOnly = true;
            this.txtBoxLastName.Size = new System.Drawing.Size(229, 22);
            this.txtBoxLastName.TabIndex = 116;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(178, 212);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(229, 22);
            this.txtBoxId.TabIndex = 117;
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Location = new System.Drawing.Point(178, 240);
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.ReadOnly = true;
            this.txtBoxContact.Size = new System.Drawing.Size(229, 22);
            this.txtBoxContact.TabIndex = 118;
            // 
            // txtBoxGender
            // 
            this.txtBoxGender.Location = new System.Drawing.Point(178, 277);
            this.txtBoxGender.Name = "txtBoxGender";
            this.txtBoxGender.ReadOnly = true;
            this.txtBoxGender.Size = new System.Drawing.Size(229, 22);
            this.txtBoxGender.TabIndex = 119;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(178, 311);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.ReadOnly = true;
            this.txtBoxAddress.Size = new System.Drawing.Size(229, 75);
            this.txtBoxAddress.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 121;
            this.label1.Text = "Student Information:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(56, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 122;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(58, 404);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(349, 48);
            this.btnChangePassword.TabIndex = 123;
            this.btnChangePassword.Text = "Change Your Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(449, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 124;
            this.label2.Text = "Exam Information:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.exam,
            this.course,
            this.mark});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(454, 144);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(199, 242);
            this.listView1.TabIndex = 126;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // exam
            // 
            this.exam.Text = "Exam";
            // 
            // course
            // 
            this.course.Text = "Course";
            // 
            // mark
            // 
            this.mark.Text = "Mark";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1037, 144);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(137, 163);
            this.dataGridView2.TabIndex = 125;
            // 
            // FormStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 496);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxGender);
            this.Controls.Add(this.txtBoxContact);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMidterm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi School Student Information System";
            this.Load += new System.EventHandler(this.FormStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciler1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private obsDataSet obsDataSet;
        private System.Windows.Forms.BindingSource ogrenciler1BindingSource;
        private obsDataSetTableAdapters.ogrenciler1TableAdapter ogrenciler1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxContact;
        private System.Windows.Forms.TextBox txtBoxGender;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader exam;
        private System.Windows.Forms.ColumnHeader course;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ColumnHeader mark;
    }
}