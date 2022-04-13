using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace eManager
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string DeptName { get; set; } = String.Empty;

        public string DeptCode { get; set; } = String.Empty;

        public List<Users>? Users { get; set; }

    }
}
