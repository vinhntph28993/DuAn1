﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Entities
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid IdHoaDonCT { get; set; }
        public Guid IdNV { get; set; }
        public DateTime CreateDate { get; set; }
        public string Note { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual List<HoaDonCT> HoaDonCTs { get; set; }
    }
}
