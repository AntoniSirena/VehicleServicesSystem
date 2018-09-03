using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VehicleServicesSystems.Models;

namespace VehicleServicesSystems.DBcontext
{
    public class MyDBcontext : DbContext
    {
        public MyDBcontext() : base("name=VehicleServices")
        {

        }

        //metodo para eliminar la plurarizacion de las entidades
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        public IDbSet<Areas> Areas { get; set; }

    }
}