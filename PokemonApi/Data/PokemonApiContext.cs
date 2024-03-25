using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonApi.Models;

namespace PokemonApi.Data
{
    public class PokemonApiContext : DbContext
    {
        public PokemonApiContext (DbContextOptions<PokemonApiContext> options)
            : base(options)
        {
        }

        public DbSet<PokemonApi.Models.Pokemon> Pokemon { get; set; } = default!;
    }
}
