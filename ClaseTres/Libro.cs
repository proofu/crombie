using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTres
{
    internal class Libro
    {
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public string ISBN {  get; set; }
        public bool isAvailable {  get; set; }
        public Libro(string titulo,string autor,string isbn) {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            isAvailable = true;
        }

        public void toString()
        {
            Console.WriteLine($"autor: {Autor},titulo {Titulo},isbn {ISBN},disponible {isAvailable}");
        }
    }
}
