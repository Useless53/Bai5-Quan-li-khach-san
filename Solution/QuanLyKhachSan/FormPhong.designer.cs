﻿namespace QuanLyKhachSan
{
    partial class FormPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhong));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.radView = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.butFree = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textState = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 583);
            this.panel5.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textNote);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textCost);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textState);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 583);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Thông tin";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textSearch);
            this.panel4.Controls.Add(this.butSearch);
            this.panel4.Controls.Add(this.butDel);
            this.panel4.Controls.Add(this.radAdd);
            this.panel4.Controls.Add(this.radEdit);
            this.panel4.Controls.Add(this.radView);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.butFree);
            this.panel4.Location = new System.Drawing.Point(72, 329);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 237);
            this.panel4.TabIndex = 12;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(27, 150);
            this.textSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(216, 27);
            this.textSearch.TabIndex = 7;
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.Location = new System.Drawing.Point(27, 188);
            this.butSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(218, 33);
            this.butSearch.TabIndex = 6;
            this.butSearch.Text = "Tìm kiếm";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDel
            // 
            this.butDel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.Location = new System.Drawing.Point(133, 96);
            this.butDel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(112, 44);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Xóa";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.BackColor = System.Drawing.Color.Transparent;
            this.radAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdd.Location = new System.Drawing.Point(27, 75);
            this.radAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(71, 23);
            this.radAdd.TabIndex = 4;
            this.radAdd.Text = "Thêm";
            this.radAdd.UseVisualStyleBackColor = false;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.BackColor = System.Drawing.Color.Transparent;
            this.radEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEdit.Location = new System.Drawing.Point(27, 108);
            this.radEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(57, 23);
            this.radEdit.TabIndex = 4;
            this.radEdit.Text = "Sửa";
            this.radEdit.UseVisualStyleBackColor = false;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radView
            // 
            this.radView.AutoSize = true;
            this.radView.BackColor = System.Drawing.Color.Transparent;
            this.radView.Checked = true;
            this.radView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radView.Location = new System.Drawing.Point(27, 40);
            this.radView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radView.Name = "radView";
            this.radView.Size = new System.Drawing.Size(64, 23);
            this.radView.TabIndex = 2;
            this.radView.TabStop = true;
            this.radView.Text = "Xem";
            this.radView.UseVisualStyleBackColor = false;
            this.radView.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chế độ";
            // 
            // butFree
            // 
            this.butFree.Enabled = false;
            this.butFree.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFree.Location = new System.Drawing.Point(133, 44);
            this.butFree.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.butFree.Name = "butFree";
            this.butFree.Size = new System.Drawing.Size(112, 44);
            this.butFree.TabIndex = 0;
            this.butFree.Text = "Xem";
            this.butFree.UseVisualStyleBackColor = true;
            this.butFree.Click += new System.EventHandler(this.butFree_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ghi chú";
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(207, 271);
            this.textNote.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textNote.Name = "textNote";
            this.textNote.ReadOnly = true;
            this.textNote.Size = new System.Drawing.Size(179, 27);
            this.textNote.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giá một ngày";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(207, 203);
            this.textCost.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textCost.Name = "textCost";
            this.textCost.ReadOnly = true;
            this.textCost.Size = new System.Drawing.Size(181, 27);
            this.textCost.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tình trạng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(207, 141);
            this.textState.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textState.Name = "textState";
            this.textState.ReadOnly = true;
            this.textState.Size = new System.Drawing.Size(181, 27);
            this.textState.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(207, 81);
            this.textID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(181, 27);
            this.textID.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 583);
            this.panel3.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SteelBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(750, 583);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trạng thái phòng";
            this.columnHeader2.Width = 145;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 583);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(768, 630);
            this.MinimumSize = new System.Drawing.Size(768, 630);
            this.Name = "FormPhong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.RadioButton radView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butFree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}