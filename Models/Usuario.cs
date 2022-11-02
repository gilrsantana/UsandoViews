using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsandoViews.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
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
                new Usuario {IdUsuario = 1, Nome = "Valdemar", Email = "valdemar@email.com"});
            Usuario.listagem.Add(
                new Usuario {IdUsuario = 2, Nome = "Ricardo", Email = "ricardo@email.com"});
            Usuario.listagem.Add(
                new Usuario {IdUsuario = 3, Nome = "Ana", Email = "ana@email.com"});
            Usuario.listagem.Add(
                new Usuario {IdUsuario = 4, Nome = "Daniela", Email = "daniela@email.com"});
            Usuario.listagem.Add(
                new Usuario {IdUsuario = 5, Nome = "Raquel", Email = "raquel@email.com"});
        }

        public static void Salvar(Usuario usuario)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.IdUsuario == usuario.IdUsuario);
            if(usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
            }
            else
            {
                int maiorIdUsuario = Usuario.Listagem.Max(u => u.IdUsuario);
                usuario.IdUsuario = maiorIdUsuario + 1;
                Usuario.listagem.Add(usuario);  
            }
        }

        public static void Excluir(Usuario usuario)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.IdUsuario == usuario.IdUsuario);
            if(usuarioExistente != null)
            {
                Usuario.listagem.Remove(usuarioExistente);
            }
            
        }
    }
}