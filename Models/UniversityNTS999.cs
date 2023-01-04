using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NguyenTungSon999.Models
{
    [Table("UniversityNTS999")]
    public class UniversityNTS999
    {
        [Key, StringLength(20), Display(Name ="ID")]
        public string? UniversityId {get; set;}
        [Required, StringLength(50), Display(Name ="Tên")]
        public string? UniversityName {get; set;}
    }
}