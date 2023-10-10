﻿using Microsoft.EntityFrameworkCore;
using PWFilmes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWFilmes.API.Context
{
    public class PWFilmesContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "server=localhost;port=3306;database=PWFIlmes;uid=root";
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Categoria> CategoriaSet { get; set; }
    }
}
