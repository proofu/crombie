using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTres
{
    internal class Biblioteca
    {
        public List<Libro> Libros {  get; set; }
        public List<Usuario> Usuarios { get; set; }

        public Biblioteca() { 
            Libros = new List<Libro>();
            Usuarios = new List<Usuario>();
        }

        public void agregarLibro(Libro libro)
        {
            Libros.Add(libro);
            Console.WriteLine($"libro agregado! Autor {libro.Autor},titulo {libro.Titulo},ISBN {libro.ISBN}");
            /*
            Console.WriteLine($"libros en esta biblioteca: ");
            for (int i = 0; i < this.Libros.Count; i++)
            {
                Console.WriteLine($"Autor: {this.Libros[i].Autor}. Titulo: {this.Libros[i].Titulo}");
            }
            */
        }

        public void agregarUsuario(string nombre, int id)
        {
            Usuario usuarioNuevo = new Usuario(nombre,id);
            Usuarios.Add(usuarioNuevo);
            Console.WriteLine($"Usuario generado: {usuarioNuevo.Nombre}, id: {usuarioNuevo.ID}");
        }

        public void prestarLibro(int IDUsuario, string inISBN)
        {
            //buscar usuario
            Usuario usuario = this.Usuarios.Find(x => x.ID == IDUsuario);
            //agregarle el libro
            Libro libro = this.Libros.Find(x => x.ISBN == inISBN);
            libro.isAvailable = false;
            usuario.LibrosPrestados.Add(libro);            
            
        }

        internal void devolverLibro(int IDUsuario, string inISBN)
        {
            Usuario usuario = this.Usuarios.Find(x => x.ID == IDUsuario);
            List<Libro> listaLibros = usuario.LibrosPrestados;
            Libro libro = listaLibros.SingleOrDefault(x => x.ISBN == inISBN);
            libro.isAvailable = true;
            if (libro != null) 
                listaLibros.Remove(libro);
            

        }

        public void verEstadoLibros()
        {
            String disponible;
            foreach (var item in Libros)
            {
                if (item.isAvailable)
                {
                    disponible = "Sí";
                } else
                {
                    disponible = "No";
                }
                Console.WriteLine($"Libro: {item.Titulo}, Disponible: {disponible}");
            }
        }
    }
}
