
namespace OgrenciOtomasyon
{
    partial class Form2
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
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtboxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsDataSet = new OgrenciOtomasyon.obsDataSet();
            this.ogrencilerTableAdapter = new OgrenciOtomasyon.obsDataSetTableAdapters.ogrencilerTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ogrencilerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.obsDataSet4 = new OgrenciOtomasyon.obsDataSet4();
            this.ogrencilerTableAdapter3 = new OgrenciOtomasyon.obsDataSet4TableAdapters.ogrencilerTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxAdres = new System.Windows.Forms.TextBox();
            this.obsDataSet5 = new OgrenciOtomasyon.obsDataSet5();
            this.ogrencilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerTableAdapter1 = new OgrenciOtomasyon.obsDataSet5TableAdapters.ogrencilerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrencilerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iletisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.BackColor = System.Drawing.Color.Transparent;
            this.lblNumara.Location = new System.Drawing.Point(53, 190);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(60, 17);
            this.lblNumara.TabIndex = 72;
            this.lblNumara.Text = "Contact:";
            // 
            // txtboxNumber
            // 
            this.txtboxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxNumber.Location = new System.Drawing.Point(190, 185);
            this.txtboxNumber.Name = "txtboxNumber";
            this.txtboxNumber.Size = new System.Drawing.Size(242, 24);
            this.txtboxNumber.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(53, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Last Name";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxLastName.Location = new System.Drawing.Point(190, 155);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(242, 24);
            this.txtBoxLastName.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "First Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(190, 125);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(242, 24);
            this.txtBoxFirstName.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(625, 67);
            this.label3.TabIndex = 66;
            this.label3.Text = "KBÜ Student Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2238, 82);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.obsDataSet;
            // 
            // obsDataSet
            // 
            this.obsDataSet.DataSetName = "obsDataSet";
            this.obsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(56, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 48);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(284, 361);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 48);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(56, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 48);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(284, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 48);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1532, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 57);
            this.btnExit.TabIndex = 84;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(56, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 48);
            this.button1.TabIndex = 87;
            this.button1.Text = "Add New Lesson";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxId.Location = new System.Drawing.Point(190, 95);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(242, 24);
            this.txtBoxId.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(53, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "ID";
            // 
            // ogrencilerBindingSource4
            // 
            this.ogrencilerBindingSource4.DataMember = "ogrenciler";
            this.ogrencilerBindingSource4.DataSource = this.obsDataSet4;
            // 
            // obsDataSet4
            // 
            this.obsDataSet4.DataSetName = "obsDataSet4";
            this.obsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerTableAdapter3
            // 
            this.ogrencilerTableAdapter3.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.radioButtonFemale);
            this.panel2.Controls.Add(this.radioButtonMale);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(190, 216);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 30);
            this.panel2.TabIndex = 91;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonFemale.Location = new System.Drawing.Point(153, 6);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonMale.Location = new System.Drawing.Point(24, 7);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 1;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(53, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 92;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(53, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "Address:";
            // 
            // txtBoxAdres
            // 
            this.txtBoxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdres.Location = new System.Drawing.Point(190, 253);
            this.txtBoxAdres.Multiline = true;
            this.txtBoxAdres.Name = "txtBoxAdres";
            this.txtBoxAdres.Size = new System.Drawing.Size(242, 91);
            this.txtBoxAdres.TabIndex = 94;
            // 
            // obsDataSet5
            // 
            this.obsDataSet5.DataSetName = "obsDataSet5";
            this.obsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerBindingSource1
            // 
            this.ogrencilerBindingSource1.DataMember = "ogrenciler";
            this.ogrencilerBindingSource1.DataSource = this.obsDataSet5;
            // 
            // ogrencilerTableAdapter1
            // 
            this.ogrencilerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.iletisimDataGridViewTextBoxColumn,
            this.dersDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrencilerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(464, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 294);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // ogrencilerBindingSource2
            // 
            this.ogrencilerBindingSource2.DataMember = "ogrenciler";
            this.ogrencilerBindingSource2.DataSource = this.obsDataSet5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // iletisimDataGridViewTextBoxColumn
            // 
            this.iletisimDataGridViewTextBoxColumn.DataPropertyName = "iletisim";
            this.iletisimDataGridViewTextBoxColumn.HeaderText = "iletisim";
            this.iletisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iletisimDataGridViewTextBoxColumn.Name = "iletisimDataGridViewTextBoxColumn";
            // 
            // dersDataGridViewTextBoxColumn
            // 
            this.dersDataGridViewTextBoxColumn.DataPropertyName = "ders";
            this.dersDataGridViewTextBoxColumn.HeaderText = "ders";
            this.dersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersDataGridViewTextBoxColumn.Name = "dersDataGridViewTextBoxColumn";
            this.dersDataGridViewTextBoxColumn.Visible = false;
            this.dersDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Width = 60;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxAdres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.txtboxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KBÜ Student Management System";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.TextBox txtboxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private obsDataSet obsDataSet;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private obsDataSetTableAdapters.ogrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label label4;
        private obsDataSet4 obsDataSet4;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource4;
        private obsDataSet4TableAdapters.ogrencilerTableAdapter ogrencilerTableAdapter3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxAdres;
        private obsDataSet5 obsDataSet5;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource1;
        private obsDataSet5TableAdapters.ogrencilerTableAdapter ogrencilerTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iletisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}