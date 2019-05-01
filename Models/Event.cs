using System;
using System.ComponentModel.DataAnnotations;

namespace AdminIB.Models
{
    public class Event
    {
        public int Id{get;set;}
        [Display(Name = "Nama Event")]
        public string NamaEvent{get;set;}
        [Display(Name = "Tanggal Mulai")]
        [DataType(DataType.Date)]
        
        public DateTime StartDate{get;set;}
        [Display(Name = "Tanggal Selesai")]
        [DataType(DataType.Date)]
        public DateTime EndDate{get;set;}
        [Display(Name = "Deskripsi")]
        public string Description{get;set;}
        [Display(Name = "Penyelenggara")]
        public string Penyelenggara{get;set;}
        [Display(Name = "Keterangan")]
        public string Keterangan{get;set;}

    }
}