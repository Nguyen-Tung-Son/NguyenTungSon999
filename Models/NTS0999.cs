using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NguyenTungSon999.Models
{
    [Table("NTS0999")]
    public class NTS0999
    {
        [Key, StringLength(20), Display(Name ="ID")]
        public string? NTSId {get; set;}
        [Required, StringLength(50), Display(Name ="Tên")]
        public string? NTSName {get; set;}
        [Required, Display(Name ="Giới tính nam")]
        public Boolean NTSGender {get; set;}
    }
}