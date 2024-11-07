using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTres
{
    internal class Usuario
    {
        public string Nombre {  get; set; }
        public int ID {  get; set; }
        public List<Libro> LibrosPrestados { get; set; }
        public Usuario(string Nombre, int ID, List<Libro> Libros)
        {
            this.Nombre = Nombre;
            this.ID = ID;
            this.LibrosPrestados = Libros;        
        }
        public Usuario(string Nombre, int ID)
        {
            this.Nombre = Nombre;
            this.ID = ID;
            this.LibrosPrestados = new List<Libro>();
        }
        public void toString()
        {
            Console.WriteLine( $"Nombre: {this.Nombre}, id: {this.ID}");
        }

        internal void mostrarLibrosPrestados()
        {
            Console.WriteLine($"libros prestados usuario {ID}: ");
            for (int i = 0; i < LibrosPrestados.Count; i++)
            {
                LibrosPrestados[i].toString();
            }
        }
    }
}
