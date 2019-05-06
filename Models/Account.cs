using System;
using System.ComponentModel.DataAnnotations;

namespace AdminIB.Models
{
    public class Account
    {   
        [Display(Name="No")]
        public int Id{get;set;}
        
        [Display(Name="Nama")]
        public string Name{get;set;}

        [Display(Name="Email")]
        public string Email{get;set;}
        
         [Display(Name="Password")]
        public string Password{get;set;}
       
       [DataType(DataType.Date)]
        [Display(Name="Created")]
        public DateTime Created{get;set;}
        
        public string Phone {get;set;}

    }
}