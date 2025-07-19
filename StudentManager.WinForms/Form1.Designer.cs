namespace StudentManager.WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.nationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(12, 188);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(776, 250);
            this.studentsDataGridView.TabIndex = 0;
            this.studentsDataGridView.SelectionChanged += new System.EventHandler(this.studentsDataGridView_SelectionChanged);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(18, 43);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // nationalCodeTextBox
            // 
            this.nationalCodeTextBox.Location = new System.Drawing.Point(284, 43);
            this.nationalCodeTextBox.Name = "nationalCodeTextBox";
            this.nationalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nationalCodeTextBox.TabIndex = 2;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(550, 43);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDatePicker.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(713, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "افزودن";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(632, 100);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "به‌روزرسانی";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(551, 100);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(470, 100);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "پاک کردن";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(224, 46); this.label1.Name = "label1"; this.label1.Size = new System.Drawing.Size(54, 13); this.label1.TabIndex = 8; this.label1.Text = "نام کامل:";
            // 
            // label2
            // 
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(490, 46); this.label2.Name = "label2"; this.label2.Size = new System.Drawing.Size(46, 13); this.label2.TabIndex = 9; this.label2.Text = "کد ملی:";
            // 
            // label3
            // 
            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(756, 46); this.label3.Name = "label3"; this.label3.Size = new System.Drawing.Size(56, 13); this.label3.TabIndex = 10; this.label3.Text = "تاریخ تولد:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullNameTextBox); this.groupBox1.Controls.Add(this.label3); this.groupBox1.Controls.Add(this.nationalCodeTextBox); this.groupBox1.Controls.Add(this.label2); this.groupBox1.Controls.Add(this.birthDatePicker); this.groupBox1.Controls.Add(this.label1); this.groupBox1.Location = new System.Drawing.Point(12, 12); this.groupBox1.Name = "groupBox1"; this.groupBox1.Size = new System.Drawing.Size(818, 82); this.groupBox1.TabIndex = 11; this.groupBox1.TabStop = false; this.groupBox1.Text = "اطلاعات دانشجو";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.groupBox1); this.Controls.Add(this.clearButton); this.Controls.Add(this.deleteButton); this.Controls.Add(this.updateButton); this.Controls.Add(this.addButton); this.Controls.Add(this.studentsDataGridView);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت دانشجویان";
            // این خط حیاتی است و رویداد را به متد صحیح متصل می‌کند
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox nationalCodeTextBox;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
