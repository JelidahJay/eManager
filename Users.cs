using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace eManager
{

 
    public class Users
    {
       [Key]
        public int UserId { get; set; }

        [ForeignKey("FK_Department")]
        public int DepartmentId { get; set; }

        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string DOB { get; set; } = String.Empty;

        public string Designation { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public string Cellphone { get; set; } = String.Empty;
        public string ContactAddress { get; set; } = String.Empty;

    }
}
