using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocGhi_Upload.Models
{
    public class Staff
    {
        public int txtId { get; set; }
        public string txtName { get; set; }
        public DateTime txtDate { get; set; }
        public decimal txtSalary { get; set; }
        public string _FileName { get; set; }
    }
}