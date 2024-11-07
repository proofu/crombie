
using ClaseTres;

//creo instancia biblioteca
Biblioteca biblioteca1 = new Biblioteca();
int option = 0;
do
{
    //MENÚ
    Console.WriteLine("Bienvenido a la Biblioteca");
    Console.WriteLine("1. Agregar libro");
    Console.WriteLine("2. Registrar usuario");
    Console.WriteLine("3. Prestar libro");
    Console.WriteLine("4. Devolver libro");
    Console.WriteLine("5. Ver estado de todos los libros");
    Console.WriteLine("6. Ver libros prestados de un usuario");    
    Console.WriteLine("7. Salir");
    Console.WriteLine("Seleccione una opción:");
    option = Int32.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            //AGREGAR LIBRO
            Console.WriteLine("agregar libro");

            Console.WriteLine("ingrese titulo");
            string titulo = Console.ReadLine();
            Console.WriteLine("ingrese autor");
            string autor = Console.ReadLine();
            Console.WriteLine("ingrese ISBN");
            string isbn = Console.ReadLine();

            Libro libro1 = new Libro(titulo, autor, isbn);
            biblioteca1.agregarLibro(libro1);
            Console.WriteLine();
            //Libro libro2 = new Libro("La sombra", "Juan Press", "4478");
            //Libro libro3 = new Libro("Bendd", "Pedro y Juan", "5748");
            //biblioteca1.agregarLibro(libro2);
            //biblioteca1.agregarLibro(libro3);

            break;
        case 2:
            //REGISTRAR USUARIO

            Console.WriteLine("agregar usuario");
            Console.WriteLine("ingrese el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese el id");
            int id = Int32.Parse(Console.ReadLine());
            biblioteca1.agregarUsuario(nombre, id);
            //biblioteca1.agregarUsuario("Pedro", 2);
            Console.WriteLine();
            break;
        case 3:
            //PRESTAR LIBRO
            Console.WriteLine("\n");
            Console.WriteLine("prestar libro");
            //pedir isbn y id usuario
            Console.WriteLine("ingrese isbn");
            string isbnPrestar = Console.ReadLine();
            Console.WriteLine("ingrese id del usuario");
            int idPrestar = Int32.Parse(Console.ReadLine());
            biblioteca1.prestarLibro(idPrestar, isbnPrestar);
            //biblioteca1.prestarLibro(1, "4478");
            //biblioteca1.prestarLibro(1, "5748");
            Console.WriteLine("libros después de prestar");
            for (int i = 0; i < biblioteca1.Usuarios.Count; i++)
            {
                //imprimir los usuarios y sus libros
                biblioteca1.Usuarios[i].mostrarLibrosPrestados();

            }
            Console.WriteLine();
            break;
        case 4:
            //DEVOLVER LIBRO
            Console.WriteLine("ingrese isbn");
            string isbnDevolver = Console.ReadLine();
            Console.WriteLine("ingrese su id para devolver el libro");
            int idDevolver = Int32.Parse(Console.ReadLine());
            biblioteca1.devolverLibro(idDevolver, isbnDevolver);
            biblioteca1.devolverLibro(1, "4478");
            //pedir isbn e id
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("libros después de devolver");
            for (int i = 0; i < biblioteca1.Usuarios.Count; i++)
            {
                //imprimir los usuarios y sus libros
                biblioteca1.Usuarios[i].mostrarLibrosPrestados();
            }
            Console.WriteLine();
            break;
        case 5:
            //VER ESTADO DE TODOS LOS LIBROS
            Console.WriteLine("");
            Console.WriteLine("listado de libros");
            biblioteca1.verEstadoLibros();
            Console.WriteLine();
            break;
        case 6:
            //VER LIBROS PRESTADOS DE UN USUARIO
            Console.WriteLine("pedir libros prestados de un usuario");
            Console.WriteLine("ingrese el id del usuario");
            int idPedido = Int32.Parse(Console.ReadLine());
            biblioteca1.Usuarios.Find(x => x.ID == idPedido).mostrarLibrosPrestados();
            Console.WriteLine();
            break;
        case 7:
            System.Environment.Exit(1);
            break;
    }
}
while (option != 7);


