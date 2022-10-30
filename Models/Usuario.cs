using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsandoViews.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; } 
        public string? Email { get; set; }

        private static List<Usuario> listagem = new List<Usuario>();

        public static IQueryable<Usuario> Listagem
        {
            get 
            {
                return listagem.AsQueryable();
            }
        }

        static Usuario()
        {
            Usuario.listagem.Add(
                new Usuario {Id = 1, Nome = "Valdemar", Email = "valdemar@email.com"});
            Usuario.listagem.Add(
                new Usuario {Id = 2, Nome = "Ricardo", Email = "ricardo@email.com"});
            Usuario.listagem.Add(
                new Usuario {Id = 3, Nome = "Ana", Email = "ana@email.com"});
            Usuario.listagem.Add(
                new Usuario {Id = 4, Nome = "Daniela", Email = "daniela@email.com"});
            Usuario.listagem.Add(
                new Usuario {Id = 5, Nome = "Raquel", Email = "raquel@email.com"});
        }
    }
}