﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ChiTietDatPhong
	{
		private Phong phong;
		private int soLuongKhach;

		public ChiTietDatPhong(Phong phong, int soLuongKhach)
		{
			this.phong = phong;
			this.soLuongKhach = soLuongKhach;
		}

		#region Properties
		public Phong Phong
		{
			get { return phong; }
			set { phong = value; }
		}

		public int SoLuongKhach
		{
			get { return soLuongKhach; }
			set { soLuongKhach = value; }
		}
		#endregion
	}
}
