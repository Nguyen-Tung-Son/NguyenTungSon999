using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace NguyenTungSon999
{
    [Table("CompanyNTS999")]
    public class CompanyNTS999 

    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string CompanyId {get;set;}
        [Required, StringLength(50), Display(Name ="Tên")]
        public String CompanyName {get;set;}
      
    }

}