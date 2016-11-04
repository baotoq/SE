﻿using DTO;
using System.Windows.Forms;

namespace GUI
{
	partial class FormMain
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
			this.groupBoxThongTinNhanVien = new System.Windows.Forms.GroupBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblTenNhanVien = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBoxLoaiPhong = new System.Windows.Forms.ComboBox();
			this.btnXemPhong = new System.Windows.Forms.Button();
			this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
			this.groupBoxTTDatPhong = new System.Windows.Forms.GroupBox();
			this.txtMaKhachHang = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimeNgayDi = new System.Windows.Forms.DateTimePicker();
			this.dateTimeNgayDen = new System.Windows.Forms.DateTimePicker();
			this.dataGridViewChiTietDatPhong = new System.Windows.Forms.DataGridView();
			this.dataGridViewDatPhong = new System.Windows.Forms.DataGridView();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.btnThemKhachHang = new System.Windows.Forms.Button();
			this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
			this.groupBoxThongTinKhachHang = new System.Windows.Forms.GroupBox();
			this.txtTelex = new System.Windows.Forms.TextBox();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtSoDienThoai = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxThongTinNhanVien.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
			this.groupBoxTTDatPhong.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDatPhong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatPhong)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
			this.groupBoxThongTinKhachHang.SuspendLayout();
			this.SuspendLayout();

			// 
			// groupBoxThongTinNhanVien
			// 
			this.groupBoxThongTinNhanVien.Controls.Add(this.btnLogout);
			this.groupBoxThongTinNhanVien.Controls.Add(this.lblTenNhanVien);
			this.groupBoxThongTinNhanVien.Location = new System.Drawing.Point(1000, 12);
			this.groupBoxThongTinNhanVien.Name = "groupBoxThongTinNhanVien";
			this.groupBoxThongTinNhanVien.Size = new System.Drawing.Size(227, 48);
			this.groupBoxThongTinNhanVien.TabIndex = 10;
			this.groupBoxThongTinNhanVien.TabStop = false;
			this.groupBoxThongTinNhanVien.Text = "Tên nhân viên";
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(135, 15);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(86, 23);
			this.btnLogout.TabIndex = 10;
			this.btnLogout.Text = "Đăng xuất";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// lblTenNhanVien
			// 
			this.lblTenNhanVien.AutoSize = true;
			this.lblTenNhanVien.Location = new System.Drawing.Point(6, 18);
			this.lblTenNhanVien.Name = "lblTenNhanVien";
			this.lblTenNhanVien.Size = new System.Drawing.Size(109, 17);
			this.lblTenNhanVien.TabIndex = 8;
			this.lblTenNhanVien.Text = "lblTenNhanVien";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(12, 64);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1215, 653);
			this.tabControl1.TabIndex = 11;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.comboBoxLoaiPhong);
			this.tabPage1.Controls.Add(this.btnXemPhong);
			this.tabPage1.Controls.Add(this.dataGridViewPhong);
			this.tabPage1.Controls.Add(this.groupBoxTTDatPhong);
			this.tabPage1.Controls.Add(this.dataGridViewChiTietDatPhong);
			this.tabPage1.Controls.Add(this.dataGridViewDatPhong);
			this.tabPage1.Controls.Add(this.btnXacNhan);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1207, 624);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Quản lý đặt phòng";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(536, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 25;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBoxLoaiPhong
			// 
			this.comboBoxLoaiPhong.FormattingEnabled = true;
			this.comboBoxLoaiPhong.Location = new System.Drawing.Point(536, 518);
			this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
			this.comboBoxLoaiPhong.Size = new System.Drawing.Size(121, 24);
			this.comboBoxLoaiPhong.TabIndex = 24;
			// 
			// btnXemPhong
			// 
			this.btnXemPhong.Location = new System.Drawing.Point(518, 476);
			this.btnXemPhong.Name = "btnXemPhong";
			this.btnXemPhong.Size = new System.Drawing.Size(75, 23);
			this.btnXemPhong.TabIndex = 23;
			this.btnXemPhong.Text = "Xem";
			this.btnXemPhong.UseVisualStyleBackColor = true;
			this.btnXemPhong.Click += new System.EventHandler(this.btnXemPhong_Click);
			// 
			// dataGridViewPhong
			// 
			this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPhong.Location = new System.Drawing.Point(56, 347);
			this.dataGridViewPhong.Name = "dataGridViewPhong";
			this.dataGridViewPhong.RowTemplate.Height = 24;
			this.dataGridViewPhong.Size = new System.Drawing.Size(403, 177);
			this.dataGridViewPhong.TabIndex = 22;
			// 
			// groupBoxTTDatPhong
			// 
			this.groupBoxTTDatPhong.Controls.Add(this.txtMaKhachHang);
			this.groupBoxTTDatPhong.Controls.Add(this.label8);
			this.groupBoxTTDatPhong.Controls.Add(this.label7);
			this.groupBoxTTDatPhong.Controls.Add(this.label6);
			this.groupBoxTTDatPhong.Controls.Add(this.dateTimeNgayDi);
			this.groupBoxTTDatPhong.Controls.Add(this.dateTimeNgayDen);
			this.groupBoxTTDatPhong.Location = new System.Drawing.Point(293, 40);
			this.groupBoxTTDatPhong.Name = "groupBoxTTDatPhong";
			this.groupBoxTTDatPhong.Size = new System.Drawing.Size(265, 124);
			this.groupBoxTTDatPhong.TabIndex = 21;
			this.groupBoxTTDatPhong.TabStop = false;
			this.groupBoxTTDatPhong.Text = "Thông tin đặt phòng";
			// 
			// txtMaKhachHang
			// 
			this.txtMaKhachHang.Location = new System.Drawing.Point(122, 27);
			this.txtMaKhachHang.Name = "txtMaKhachHang";
			this.txtMaKhachHang.Size = new System.Drawing.Size(131, 22);
			this.txtMaKhachHang.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Mã khách hàng:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Ngày đến:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "Ngày đi:";
			// 
			// dateTimeNgayDi
			// 
			this.dateTimeNgayDi.CustomFormat = "dd/MM/yyyy";
			this.dateTimeNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeNgayDi.Location = new System.Drawing.Point(122, 83);
			this.dateTimeNgayDi.Name = "dateTimeNgayDi";
			this.dateTimeNgayDi.Size = new System.Drawing.Size(131, 22);
			this.dateTimeNgayDi.TabIndex = 11;
			// 
			// dateTimeNgayDen
			// 
			this.dateTimeNgayDen.CustomFormat = "dd/MM/yyyy";
			this.dateTimeNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeNgayDen.Location = new System.Drawing.Point(122, 55);
			this.dateTimeNgayDen.Name = "dateTimeNgayDen";
			this.dateTimeNgayDen.Size = new System.Drawing.Size(131, 22);
			this.dateTimeNgayDen.TabIndex = 10;
			// 
			// dataGridViewChiTietDatPhong
			// 
			this.dataGridViewChiTietDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewChiTietDatPhong.Location = new System.Drawing.Point(714, 81);
			this.dataGridViewChiTietDatPhong.Name = "dataGridViewChiTietDatPhong";
			this.dataGridViewChiTietDatPhong.RowTemplate.Height = 24;
			this.dataGridViewChiTietDatPhong.Size = new System.Drawing.Size(356, 230);
			this.dataGridViewChiTietDatPhong.TabIndex = 20;
			// 
			// dataGridViewDatPhong
			// 
			this.dataGridViewDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDatPhong.Location = new System.Drawing.Point(6, 6);
			this.dataGridViewDatPhong.Name = "dataGridViewDatPhong";
			this.dataGridViewDatPhong.RowTemplate.Height = 24;
			this.dataGridViewDatPhong.Size = new System.Drawing.Size(180, 175);
			this.dataGridViewDatPhong.TabIndex = 0;
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.Location = new System.Drawing.Point(438, 179);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(124, 23);
			this.btnXacNhan.TabIndex = 14;
			this.btnXacNhan.Text = "Xác nhận";
			this.btnXacNhan.UseVisualStyleBackColor = true;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1207, 624);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Quản lý thuê phòng";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.btnThemKhachHang);
			this.tabPage4.Controls.Add(this.dataGridViewKhachHang);
			this.tabPage4.Controls.Add(this.groupBoxThongTinKhachHang);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1207, 624);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Quản lý khách hàng";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// btnThemKhachHang
			// 
			this.btnThemKhachHang.Location = new System.Drawing.Point(958, 122);
			this.btnThemKhachHang.Name = "btnThemKhachHang";
			this.btnThemKhachHang.Size = new System.Drawing.Size(75, 23);
			this.btnThemKhachHang.TabIndex = 3;
			this.btnThemKhachHang.Text = "Thêm";
			this.btnThemKhachHang.UseVisualStyleBackColor = true;
			this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
			// 
			// dataGridViewKhachHang
			// 
			this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewKhachHang.Location = new System.Drawing.Point(17, 9);
			this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
			this.dataGridViewKhachHang.RowTemplate.Height = 24;
			this.dataGridViewKhachHang.Size = new System.Drawing.Size(585, 612);
			this.dataGridViewKhachHang.TabIndex = 2;
			// 
			// groupBoxThongTinKhachHang
			// 
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtTelex);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtFax);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtSoDienThoai);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtDiaChi);
			this.groupBoxThongTinKhachHang.Controls.Add(this.txtHoTen);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label5);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label3);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label4);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label2);
			this.groupBoxThongTinKhachHang.Controls.Add(this.label1);
			this.groupBoxThongTinKhachHang.Location = new System.Drawing.Point(608, 9);
			this.groupBoxThongTinKhachHang.Name = "groupBoxThongTinKhachHang";
			this.groupBoxThongTinKhachHang.Size = new System.Drawing.Size(275, 185);
			this.groupBoxThongTinKhachHang.TabIndex = 1;
			this.groupBoxThongTinKhachHang.TabStop = false;
			this.groupBoxThongTinKhachHang.Text = "Thông tin khách hàng";
			// 
			// txtTelex
			// 
			this.txtTelex.Location = new System.Drawing.Point(138, 146);
			this.txtTelex.Name = "txtTelex";
			this.txtTelex.Size = new System.Drawing.Size(124, 22);
			this.txtTelex.TabIndex = 9;
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(138, 116);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(124, 22);
			this.txtFax.TabIndex = 8;
			// 
			// txtSoDienThoai
			// 
			this.txtSoDienThoai.Location = new System.Drawing.Point(138, 86);
			this.txtSoDienThoai.Name = "txtSoDienThoai";
			this.txtSoDienThoai.Size = new System.Drawing.Size(124, 22);
			this.txtSoDienThoai.TabIndex = 7;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(138, 56);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(124, 22);
			this.txtDiaChi.TabIndex = 6;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(138, 26);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(124, 22);
			this.txtHoTen.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Số telex:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Số fax:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Số điện thoại:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Địa chỉ:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ tên:";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1239, 729);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBoxThongTinNhanVien);
			this.Name = "FormMain";
			this.Text = "Form";
			this.groupBoxThongTinNhanVien.ResumeLayout(false);
			this.groupBoxThongTinNhanVien.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
			this.groupBoxTTDatPhong.ResumeLayout(false);
			this.groupBoxTTDatPhong.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDatPhong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatPhong)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
			this.groupBoxThongTinKhachHang.ResumeLayout(false);
			this.groupBoxThongTinKhachHang.PerformLayout();
			this.ResumeLayout(false);
			this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
			comboBoxLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxLoaiPhong.Items.AddRange(new object[] { "Tất cả", LoaiPhong.A, LoaiPhong.B, LoaiPhong.C, LoaiPhong.D });
			comboBoxLoaiPhong.SelectedIndex = 0;
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxThongTinNhanVien;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblTenNhanVien;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBoxThongTinKhachHang;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateTimeNgayDi;
		private System.Windows.Forms.DateTimePicker dateTimeNgayDen;
		private System.Windows.Forms.TextBox txtTelex;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.TextBox txtSoDienThoai;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewDatPhong;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnXacNhan;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button btnThemKhachHang;
		private System.Windows.Forms.DataGridView dataGridViewKhachHang;
		private System.Windows.Forms.GroupBox groupBoxTTDatPhong;
		private System.Windows.Forms.DataGridView dataGridViewChiTietDatPhong;
		private System.Windows.Forms.ComboBox comboBoxLoaiPhong;
		private System.Windows.Forms.Button btnXemPhong;
		private System.Windows.Forms.DataGridView dataGridViewPhong;
		private System.Windows.Forms.TextBox txtMaKhachHang;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
	}
}
