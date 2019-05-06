using System;
using System.ComponentModel.DataAnnotations;

namespace AdminIB.Models
{
    public class Account
    {
        public int Id{get;set;}
        [Display(Name="No")]
        public string Name{get;set;}
        [Display(Name="Nama")]
        public string Email{get;set;}
        [Display(Name="Email")]
        public string Password{get;set;}
        [Display(Name="Password")]
       
        public DateTime Created{get;set;}
        [DataType(DataType.Date)]
        public string Phone {get;set;}

    }
}