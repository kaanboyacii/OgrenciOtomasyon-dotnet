
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
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsDataSet = new OgrenciOtomasyon.obsDataSet();
            this.ogrencilerTableAdapter = new OgrenciOtomasyon.obsDataSetTableAdapters.ogrencilerTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxProgram = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxMidtermExam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxFinalExam = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.BackColor = System.Drawing.Color.Transparent;
            this.lblNumara.Location = new System.Drawing.Point(51, 189);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(111, 17);
            this.lblNumara.TabIndex = 72;
            this.lblNumara.Text = "Student Number";
            // 
            // txtboxNumber
            // 
            this.txtboxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxNumber.Location = new System.Drawing.Point(188, 184);
            this.txtboxNumber.Name = "txtboxNumber";
            this.txtboxNumber.Size = new System.Drawing.Size(242, 24);
            this.txtboxNumber.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Last Name";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxLastName.Location = new System.Drawing.Point(188, 138);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(242, 24);
            this.txtBoxLastName.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "First Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(188, 95);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dataGridView1.DataSource = this.ogrencilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(474, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 417);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "numara";
            this.numaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            this.numaraDataGridViewTextBoxColumn.ReadOnly = true;
            this.numaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "program";
            this.programDataGridViewTextBoxColumn.HeaderText = "program";
            this.programDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            this.programDataGridViewTextBoxColumn.ReadOnly = true;
            this.programDataGridViewTextBoxColumn.Width = 125;
            // 
            // vizeDataGridViewTextBoxColumn
            // 
            this.vizeDataGridViewTextBoxColumn.DataPropertyName = "vize";
            this.vizeDataGridViewTextBoxColumn.HeaderText = "vize";
            this.vizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vizeDataGridViewTextBoxColumn.Name = "vizeDataGridViewTextBoxColumn";
            this.vizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vizeDataGridViewTextBoxColumn.Width = 40;
            // 
            // finalDataGridViewTextBoxColumn
            // 
            this.finalDataGridViewTextBoxColumn.DataPropertyName = "final";
            this.finalDataGridViewTextBoxColumn.HeaderText = "final";
            this.finalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalDataGridViewTextBoxColumn.Name = "finalDataGridViewTextBoxColumn";
            this.finalDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalDataGridViewTextBoxColumn.Width = 40;
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "ortalama";
            this.ortalamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            this.ortalamaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ortalamaDataGridViewTextBoxColumn.Width = 50;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.ReadOnly = true;
            this.durumDataGridViewTextBoxColumn.Width = 50;
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
            this.btnAdd.Location = new System.Drawing.Point(54, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 48);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(51, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Program";
            // 
            // txtBoxProgram
            // 
            this.txtBoxProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxProgram.Location = new System.Drawing.Point(188, 227);
            this.txtBoxProgram.Name = "txtBoxProgram";
            this.txtBoxProgram.Size = new System.Drawing.Size(242, 24);
            this.txtBoxProgram.TabIndex = 75;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(253, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 48);
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
            this.btnDelete.Location = new System.Drawing.Point(54, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 48);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(253, 464);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 48);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(51, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 81;
            this.label5.Text = "Midterm Exam:";
            // 
            // txtBoxMidtermExam
            // 
            this.txtBoxMidtermExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMidtermExam.Location = new System.Drawing.Point(174, 269);
            this.txtBoxMidtermExam.Name = "txtBoxMidtermExam";
            this.txtBoxMidtermExam.Size = new System.Drawing.Size(44, 24);
            this.txtBoxMidtermExam.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(279, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Final Exam:";
            // 
            // txtBoxFinalExam
            // 
            this.txtBoxFinalExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxFinalExam.Location = new System.Drawing.Point(386, 269);
            this.txtBoxFinalExam.Name = "txtBoxFinalExam";
            this.txtBoxFinalExam.Size = new System.Drawing.Size(44, 24);
            this.txtBoxFinalExam.TabIndex = 82;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 614);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxFinalExam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxMidtermExam);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxProgram);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
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
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private obsDataSet obsDataSet;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private obsDataSetTableAdapters.ogrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxProgram;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxMidtermExam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxFinalExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
    }
}