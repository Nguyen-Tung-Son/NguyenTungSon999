using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace NguyenTungSon999
{
    [Table("NTS0999")]
    public class NTS0999 
    {
        [Key,StringLength(20),Display(Name ="ID")]
        public string NTSId {get;set;}
        [Required, StringLength(50),Display(Name ="Họ và tên")]
        public string NTSName {get;set;}
        [Required, Display(Name ="Giới tính nam")]
        public bool NTSGender {get;set;}

    }

    

}