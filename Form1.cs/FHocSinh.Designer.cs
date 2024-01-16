namespace Form1.cs
{
    partial class FHocSinh
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
            this.btAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btTeacher = new System.Windows.Forms.Button();
            this.lblAddressed = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btTatChuongTrinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(19, 477);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(478, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 399);
            this.dataGridView1.TabIndex = 1;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(122, 477);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 22);
            this.textBox1.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(225, 477);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btTeacher
            // 
            this.btTeacher.Location = new System.Drawing.Point(321, 477);
            this.btTeacher.Name = "btTeacher";
            this.btTeacher.Size = new System.Drawing.Size(75, 23);
            this.btTeacher.TabIndex = 6;
            this.btTeacher.Text = "Teacher";
            this.btTeacher.UseVisualStyleBackColor = true;
            this.btTeacher.Click += new System.EventHandler(this.btTeacher_Click);
            // 
            // lblAddressed
            // 
            this.lblAddressed.AutoSize = true;
            this.lblAddressed.Location = new System.Drawing.Point(55, 124);
            this.lblAddressed.Name = "lblAddressed";
            this.lblAddressed.Size = new System.Drawing.Size(74, 16);
            this.lblAddressed.TabIndex = 8;
            this.lblAddressed.Text = "Addressed";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(55, 199);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(55, 286);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(56, 16);
            this.lblBirthday.TabIndex = 10;
            this.lblBirthday.Text = "Birthday";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 22);
            this.textBox3.TabIndex = 12;
            // 
            // btTatChuongTrinh
            // 
            this.btTatChuongTrinh.Location = new System.Drawing.Point(825, 477);
            this.btTatChuongTrinh.Name = "btTatChuongTrinh";
            this.btTatChuongTrinh.Size = new System.Drawing.Size(206, 23);
            this.btTatChuongTrinh.TabIndex = 13;
            this.btTatChuongTrinh.Text = "Tắt Chương Trình";
            this.btTatChuongTrinh.UseVisualStyleBackColor = true;
            this.btTatChuongTrinh.Click += new System.EventHandler(this.btTatChuongTrinh_Click);
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 540);
            this.Controls.Add(this.btTatChuongTrinh);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAddressed);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btTeacher);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btAdd);
            this.Name = "FHocSinh";
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.FHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btTeacher;
        private System.Windows.Forms.Label lblAddressed;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btTatChuongTrinh;
    }
}

