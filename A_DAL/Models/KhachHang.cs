﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public Guid HopDongId { get; set; }
        public string? Ten { get; set; }
        public int GioiTinh { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public string? Quequan { get; set; }
        public string? CMND { get; set; }
        public virtual HopDong? HopDong { get; set; }
    }
}
