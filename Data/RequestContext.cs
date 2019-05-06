using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdminIB.Models;

namespace AdminIB.Models
{
    public class RequestContext : DbContext
    {
        public RequestContext(DbContextOptions<RequestContext> options) : base(options)
        {

        }
        public DbSet<AdminIB.Models.Request> Request { get; set; }
        public DbSet<AdminIB.Models.Event> Event{get;set;}
        public DbSet<AdminIB.Models.Account> Account{get;set;}
    }
}