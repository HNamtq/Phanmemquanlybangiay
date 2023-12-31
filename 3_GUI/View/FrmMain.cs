﻿using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI.View
{
	public partial class FrmMain : Form
	{
		INhanVienServices _inhanVienServices;
		IChucVuServices _chucVuServices;
		public FrmMain()
		{
			InitializeComponent();
			_inhanVienServices = new NhanVienServices();
			_chucVuServices = new ChucVuServices();
		}

		private void btn_NhanVien_Click(object sender, EventArgs e)
		{
			Guid idRole = _inhanVienServices.GetAllViewNhanVien().FirstOrDefault(x => x.Username == Properties.Settings.Default.TKdaLogin).ID;
			var id = _inhanVienServices.GetAllNhanVien().FirstOrDefault(p => p.ID == idRole).IDCV;
			var idcv = _chucVuServices.GetAll().FirstOrDefault(p => p.ID == id).Ten;
			if (idcv == "Quản lý")
			{

				this.panel3.Controls.Clear();
				FrmCV_NV frmQLNhanVien = new FrmCV_NV() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
				this.panel3.Controls.Add(frmQLNhanVien);
				frmQLNhanVien.Show();
			}
			else if (idcv != "Quản lý")
			{
				MessageBox.Show("Nhân viên không có quyền sử dụng chức năng này");
			}
		}

		private void btn_SP_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmQuanLySanPham frmQLChiTietSP = new FrmQuanLySanPham() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}

		private void btn_KH_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmKhachHang frmQLChiTietSP = new FrmKhachHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}

		private void btn_BanHang_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmBanHang frmQLChiTietSP = new FrmBanHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}

		private void btn_HD_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmHoaDon frmQLChiTietSP = new FrmHoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}

		private void btn_DMK_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_TK_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmThongKe frmQLChiTietSP = new FrmThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}
	}
}
