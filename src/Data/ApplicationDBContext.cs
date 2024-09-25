using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiEnsayoNuevo.src.Models;
using Microsoft.EntityFrameworkCore;

namespace apiEnsayoNuevo.src.Data
{
    public class ApplicationDBContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        DbSet<Product> Products { get; set; }
    }
}