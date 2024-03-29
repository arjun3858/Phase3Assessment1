﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phase3Assessment1.Models
{
    [Table("DeptMaster")]
    public class DeptMaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string ?DeptName { get; set; }
       
        public virtual ICollection<EmpProfile> ?EmpProfile { get; set; }
    }
}
