
namespace OgrenciOtomasyon.Student
{
    partial class ExamResult
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxExamId = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtboxCourseId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.obsDataSet7 = new OgrenciOtomasyon.obsDataSet7();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new OgrenciOtomasyon.obsDataSet7TableAdapters.courseTableAdapter();
            this.examresultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exam_resultTableAdapter = new OgrenciOtomasyon.obsDataSet7TableAdapters.exam_resultTableAdapter();
            this.examidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter = new OgrenciOtomasyon.obsDataSet7TableAdapters.examTableAdapter();
            this.examidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examresultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1271, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 64);
            this.btnExit.TabIndex = 132;
            this.btnExit.Text = "Back Student Page";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examidDataGridViewTextBoxColumn,
            this.studentidDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn1,
            this.marksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.examresultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(467, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 352);
            this.dataGridView1.TabIndex = 131;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(61, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(376, 48);
            this.btnDelete.TabIndex = 130;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(58, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 129;
            this.label4.Text = "Exam ID:";
            // 
            // txtBoxExamId
            // 
            this.txtBoxExamId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxExamId.Location = new System.Drawing.Point(195, 95);
            this.txtBoxExamId.Name = "txtBoxExamId";
            this.txtBoxExamId.Size = new System.Drawing.Size(242, 24);
            this.txtBoxExamId.TabIndex = 128;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(329, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 36);
            this.btnClear.TabIndex = 126;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(61, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(376, 48);
            this.btnUpdate.TabIndex = 125;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(61, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(376, 48);
            this.btnAdd.TabIndex = 124;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.BackColor = System.Drawing.Color.Transparent;
            this.lblNumara.Location = new System.Drawing.Point(58, 160);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(74, 17);
            this.lblNumara.TabIndex = 123;
            this.lblNumara.Text = "Course ID:";
            // 
            // txtboxCourseId
            // 
            this.txtboxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxCourseId.Location = new System.Drawing.Point(195, 155);
            this.txtboxCourseId.Name = "txtboxCourseId";
            this.txtboxCourseId.Size = new System.Drawing.Size(242, 24);
            this.txtboxCourseId.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(58, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Mark:";
            // 
            // txtBoxMark
            // 
            this.txtBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMark.Location = new System.Drawing.Point(195, 185);
            this.txtBoxMark.Name = "txtBoxMark";
            this.txtBoxMark.Size = new System.Drawing.Size(106, 24);
            this.txtBoxMark.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(58, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 119;
            this.label2.Text = "Student ID:";
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxStudentId.Location = new System.Drawing.Point(195, 125);
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(242, 24);
            this.txtBoxStudentId.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(475, 67);
            this.label3.TabIndex = 117;
            this.label3.Text = "Exam Result Management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2238, 82);
            this.pictureBox2.TabIndex = 116;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.gradeidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.courseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(886, 95);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(294, 352);
            this.dataGridView2.TabIndex = 133;
            // 
            // obsDataSet7
            // 
            this.obsDataSet7.DataSetName = "obsDataSet7";
            this.obsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.obsDataSet7;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // examresultBindingSource
            // 
            this.examresultBindingSource.DataMember = "exam_result";
            this.examresultBindingSource.DataSource = this.obsDataSet7;
            // 
            // exam_resultTableAdapter
            // 
            this.exam_resultTableAdapter.ClearBeforeFill = true;
            // 
            // examidDataGridViewTextBoxColumn
            // 
            this.examidDataGridViewTextBoxColumn.DataPropertyName = "exam_id";
            this.examidDataGridViewTextBoxColumn.HeaderText = "exam_id";
            this.examidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examidDataGridViewTextBoxColumn.Name = "examidDataGridViewTextBoxColumn";
            this.examidDataGridViewTextBoxColumn.Width = 60;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Width = 75;
            // 
            // courseidDataGridViewTextBoxColumn1
            // 
            this.courseidDataGridViewTextBoxColumn1.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn1.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn1.Name = "courseidDataGridViewTextBoxColumn1";
            this.courseidDataGridViewTextBoxColumn1.Width = 75;
            // 
            // marksDataGridViewTextBoxColumn
            // 
            this.marksDataGridViewTextBoxColumn.DataPropertyName = "marks";
            this.marksDataGridViewTextBoxColumn.HeaderText = "marks";
            this.marksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marksDataGridViewTextBoxColumn.Name = "marksDataGridViewTextBoxColumn";
            this.marksDataGridViewTextBoxColumn.Width = 50;
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            this.courseidDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeidDataGridViewTextBoxColumn
            // 
            this.gradeidDataGridViewTextBoxColumn.DataPropertyName = "grade_id";
            this.gradeidDataGridViewTextBoxColumn.HeaderText = "grade_id";
            this.gradeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeidDataGridViewTextBoxColumn.Name = "gradeidDataGridViewTextBoxColumn";
            this.gradeidDataGridViewTextBoxColumn.Visible = false;
            this.gradeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examidDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.examBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(1203, 95);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(336, 352);
            this.dataGridView3.TabIndex = 134;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "exam";
            this.examBindingSource.DataSource = this.obsDataSet7;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // examidDataGridViewTextBoxColumn1
            // 
            this.examidDataGridViewTextBoxColumn1.DataPropertyName = "exam_id";
            this.examidDataGridViewTextBoxColumn1.HeaderText = "exam_id";
            this.examidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.examidDataGridViewTextBoxColumn1.Name = "examidDataGridViewTextBoxColumn1";
            this.examidDataGridViewTextBoxColumn1.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "start_Date";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "start_Date";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // ExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 459);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxExamId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.txtboxCourseId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxStudentId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "ExamResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi School Student Management System";
            this.Load += new System.EventHandler(this.ExamResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examresultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxExamId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.TextBox txtboxCourseId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private obsDataSet7 obsDataSet7;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private obsDataSet7TableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource examresultBindingSource;
        private obsDataSet7TableAdapters.exam_resultTableAdapter exam_resultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn examidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource examBindingSource;
        private obsDataSet7TableAdapters.examTableAdapter examTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn examidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
    }
}