using System;
using System.ComponentModel.DataAnnotations;

namespace AdminIB.Models
{
    public class Request
    {
        public int Id{get;set;}
        [Display(Name = "No")]
        public int ClientId{get;set;}
        [Display(Name = "Nama Mahasiswa")]
        public string NamaMahasiswa{get;set;}
        [Display(Name = "NIM Mahasiswa")]
        public string NIMMahasiswa{get;set;}
        [Display(Name = "Tanggal Keberangkatan")]
        [DataType(DataType.Date)]
        
        public DateTime DepartureDate{get;set;}
        [Display(Name = "Tanggal Kepulangan")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate{get;set;}
        [Display(Name = "Keperluan")]
        public string Reason{get;set;}
        [Display(Name = "Tujuan")]
        public string Destination{get;set;}
        public string Status{get;set;}

    }
}