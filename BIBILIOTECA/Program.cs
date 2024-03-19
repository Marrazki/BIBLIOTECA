//Ejercicio: Sistema de Gestión de Biblioteca


//Desarrollad un programa en grupos de 1 o 2 personas para gestionar un
//sistema simple de biblioteca.



//El programa debe permitir a los usuarios realizar las siguientes operaciones:

//1.Agregar Libro:
//• Cada libro debe tener un título, autor y número de ISBN único.
//• Los detalles del libro se deben almacenar en sólo una estructura
//de datos.

//2. Prestar Libro:
//• Un usuario puede tomar prestado un libro introduciendo el
//número de ISBN.
//• El sistema debe verificar si el libro está disponible antes de
//prestarlo.

//3. Devolver Libro:
//• Un usuario puede devolver un libro introduciendo el número de
//ISBN.
//• El sistema debe verificar si el libro pertenece a la biblioteca y si
//está prestado.

//4. Buscar Libro:
//• Permitir a los usuarios buscar un libro por título, autor o ISBN.
//• Mostrar todos los libros que coincidan con la búsqueda.

//5. Listar Libros Disponibles:
//• Mostrar una lista de todos los libros disponibles en la biblioteca.


//Requisitos Técnicos:
//• Usad funciones y acciones para organizar el código y facilitar la
//modularidad.
//• Utilizad la cantidad justa y necesaria de estructuras de datos. Para
//guardar los libros, puedes utilizar un vector de las dimensiones que
//necesites.
//• Proporcionad un menú interactivo para que los usuarios realicen las
//operaciones.
//• Recordad que los únicos tipos de datos válidos para la práctica son: int,
//double, bool y char. De igual forma, no se puede utilizar nada que no se
//haya dado en clase. Si tenéis dudas sobre qué contenido es aceptable,
//podéis preguntarme.

//La entrega consiste en:
//UNIVERSIDAD EUNEIZ Paseo de la Biosfera nº 6 -01013 Vitoria-Gasteiz (Álava)

//1 – El código de un programa hecho en C# (Si no compila, la nota final será
//acotada superiormente por 5).

//2 – Una memoria. Debéis entregar un documento en el que me expliquéis qué
//decisiones habéis tomado, por qué, qué partes os han parecido más desafiantes,
//por qué, cómo las habéis resuelto, y qué alternativas habéis barajado.
//Aseguraos de incluir el tiempo que habéis invertido en la práctica y donde se ha
//ido ese tiempo.
//Es posible que a discreción del profesorado se hagan preguntas adicionales o
//entrevistas individuales o en grupo para hablar de la entrega.



//0 Título
//1 Autor
//2 ISBM

//Posición

//Libro

//Disponible




/*
//Título, Autor, ISBM
Biblioteca[0, 0,] = '';
Biblioteca[0, 1,] = '';
Biblioteca[0, 2,] = '';
Biblioteca[0, 3,] = '';
Biblioteca[0, 4,] = '';
Biblioteca[0, 5,] = '';
Biblioteca[0, 6,] = '';
Biblioteca[0, 7,] = '';
Biblioteca[0, 8,] = '';
Biblioteca[0, 9,] = '';
Biblioteca[0, 10,] = '';
Biblioteca[0, 11,] = '';
Biblioteca[0, 12,] = '';
Biblioteca[0, 13,] = '';
Biblioteca[0, 14,] = '';
Biblioteca[0, 15,] = '';
Biblioteca[0, 16,] = '';
Biblioteca[0, 17,] = '';
Biblioteca[0, 18,] = '';
Biblioteca[0, 19,] = '';
Biblioteca[0, 20,] = '';
Biblioteca[0, 21,] = '';
Biblioteca[0, 22,] = '';
Biblioteca[0, 23,] = '';

//Autor

Biblioteca[1, 0,] = '';
Biblioteca[1, 1,] = '';
Biblioteca[1, 2,] = '';
Biblioteca[1, 3,] = '';
Biblioteca[1, 4,] = '';
Biblioteca[1, 5,] = '';
Biblioteca[1, 6,] = '';
Biblioteca[1, 7,] = '';
Biblioteca[1, 8,] = '';
Biblioteca[1, 9,] = '';
Biblioteca[1, 10,] = '';
Biblioteca[1, 11,] = '';

//ISBM

Biblioteca[2, 0,] = '';
Biblioteca[2, 1,] = '';
Biblioteca[2, 2,] = '';
Biblioteca[2, 3,] = '';
Biblioteca[2, 4,] = '';
Biblioteca[2, 5,] = '';
Biblioteca[2, 6,] = '';
Biblioteca[2, 7,] = '';
Biblioteca[2, 8,] = '';
Biblioteca[2, 9,] = '';

//Disponible

Biblioteca[3, 0,] = '';

*/

















char[,,] Biblioteca = new char[4,50,1000];
//Momo, Michael Ende, 8490260907, Disponible
Biblioteca[0, 0, 0] = 'M';
Biblioteca[0, 1, 0] = 'o';
Biblioteca[0, 2, 0] = 'm';
Biblioteca[0, 3, 0] = 'o';

//Autor

Biblioteca[1, 0, 0] = 'M';
Biblioteca[1, 1, 0] = 'i';
Biblioteca[1, 2, 0] = 'c';
Biblioteca[1, 3, 0] = 'h';
Biblioteca[1, 4, 0] = 'a';
Biblioteca[1, 5, 0] = 'e';
Biblioteca[1, 6, 0] = 'l';
Biblioteca[1, 7, 0] = ' ';
Biblioteca[1, 8, 0] = 'E';
Biblioteca[1, 9, 0] = 'n';
Biblioteca[1, 10, 0] = 'd';
Biblioteca[1, 11, 0] = 'e';

//8490260907

Biblioteca[2, 0, 0] = '8';
Biblioteca[2, 1, 0] = '4';
Biblioteca[2, 2, 0] = '9';
Biblioteca[2, 3, 0] = '0';
Biblioteca[2, 4, 0] = '2';
Biblioteca[2, 5, 0] = '6';
Biblioteca[2, 6, 0] = '0';
Biblioteca[2, 7, 0] = '9';
Biblioteca[2, 8, 0] = '0';
Biblioteca[2, 9, 0] = '7';

//Disponible

Biblioteca[3, 0, 0] = '1';

//Colmillo Blanco, Jack London, 1479393169, Disponible
Biblioteca[0, 0, 1] = 'C';
Biblioteca[0, 1, 1] = 'o';
Biblioteca[0, 2, 1] = 'l';
Biblioteca[0, 3, 1] = 'm';
Biblioteca[0, 4, 1] = 'i';
Biblioteca[0, 5, 1] = 'l';
Biblioteca[0, 6, 1] = 'l';
Biblioteca[0, 7, 1] = 'o';
Biblioteca[0, 8, 1] = ' ';
Biblioteca[0, 9, 1] = 'B';
Biblioteca[0, 10, 1] = 'l';
Biblioteca[0, 11, 1] = 'a';
Biblioteca[0, 12, 1] = 'n';
Biblioteca[0, 13, 1] = 'c';
Biblioteca[0, 14, 1] = 'o';

//Autor

Biblioteca[1, 0, 1] = 'J';
Biblioteca[1, 1, 1] = 'a';
Biblioteca[1, 2, 1] = 'c';
Biblioteca[1, 3, 1] = 'k';
Biblioteca[1, 4, 1] = ' ';
Biblioteca[1, 5, 1] = 'L';
Biblioteca[1, 6, 1] = 'o';
Biblioteca[1, 7, 1] = 'n';
Biblioteca[1, 8, 1] = 'd';
Biblioteca[1, 9, 1] = 'o';
Biblioteca[1, 10, 1] = 'n';

//1479393169

Biblioteca[2, 0, 1] = '1';
Biblioteca[2, 1, 1] = '4';
Biblioteca[2, 2, 1] = '7';
Biblioteca[2, 3, 1] = '9';
Biblioteca[2, 4, 1] = '3';
Biblioteca[2, 5, 1] = '9';
Biblioteca[2, 6, 1] = '3';
Biblioteca[2, 7, 1] = '1';
Biblioteca[2, 8, 1] = '6';
Biblioteca[2, 9, 1] = '9';

//Disponible

Biblioteca[3, 0, 1] = '1';


//La Historia Interminable, Michael Ende, 8420471542, Disponible
Biblioteca[0, 0, 2] = 'L';
Biblioteca[0, 1, 2] = 'a';
Biblioteca[0, 2, 2] = ' ';
Biblioteca[0, 3, 2] = 'H';
Biblioteca[0, 4, 2] = 'i';
Biblioteca[0, 5, 2] = 's';
Biblioteca[0, 6, 2] = 't';
Biblioteca[0, 7, 2] = 'o';
Biblioteca[0, 8, 2] = 'r';
Biblioteca[0, 9, 2] = 'i';
Biblioteca[0, 10, 2] = 'a';
Biblioteca[0, 11, 2] = ' ';
Biblioteca[0, 12, 2] = 'i';
Biblioteca[0, 13, 2] = 'n';
Biblioteca[0, 14, 2] = 't';
Biblioteca[0, 15, 2] = 'e';
Biblioteca[0, 16, 2] = 'r';
Biblioteca[0, 17, 2] = 'm';
Biblioteca[0, 18, 2] = 'i';
Biblioteca[0, 19, 2] = 'n';
Biblioteca[0, 20, 2] = 'a';
Biblioteca[0, 21, 2] = 'b';
Biblioteca[0, 22, 2] = 'l';
Biblioteca[0, 23, 2] = 'e';

//Autor

Biblioteca[1, 0, 2] = 'M';
Biblioteca[1, 1, 2] = 'i';
Biblioteca[1, 2, 2] = 'c';
Biblioteca[1, 3, 2] = 'h';
Biblioteca[1, 4, 2] = 'a';
Biblioteca[1, 5, 2] = 'e';
Biblioteca[1, 6, 2] = 'l';
Biblioteca[1, 7, 2] = ' ';
Biblioteca[1, 8, 2] = 'E';
Biblioteca[1, 9, 2] = 'n';
Biblioteca[1, 14, 2] = 'd';
Biblioteca[1, 15, 2] = 'e';

//8420471542

Biblioteca[2, 0, 2] = '8';
Biblioteca[2, 1, 2] = '4';
Biblioteca[2, 2, 2] = '2';
Biblioteca[2, 3, 2] = '0';
Biblioteca[2, 4, 2] = '4';
Biblioteca[2, 5, 2] = '7';
Biblioteca[2, 6, 2] = '1';
Biblioteca[2, 7, 2] = '5';
Biblioteca[2, 8, 2] = '4';
Biblioteca[2, 9, 2] = '2';

//Disponible

Biblioteca[3, 0, 2] = '1';

//Minecraft. Guia De Construccion, Montena, 6073136005, Disponible
Biblioteca[0, 0, 3] = 'M';
Biblioteca[0, 1, 3] = 'i';
Biblioteca[0, 2, 3] = 'n';
Biblioteca[0, 3, 3] = 'e';
Biblioteca[0, 4, 3] = 'c';
Biblioteca[0, 5, 3] = 'r';
Biblioteca[0, 6, 3] = 'a';
Biblioteca[0, 7, 3] = 'f';
Biblioteca[0, 8, 3] = 't';
Biblioteca[0, 9, 3] = '.';
Biblioteca[0, 10, 3] = ' ';
Biblioteca[0, 11, 3] = 'G';
Biblioteca[0, 12, 3] = 'u';
Biblioteca[0, 13, 3] = 'i';
Biblioteca[0, 14, 3] = 'a';
Biblioteca[0, 15, 3] = ' ';
Biblioteca[0, 16, 3] = 'D';
Biblioteca[0, 17, 3] = 'e';
Biblioteca[0, 18, 3] = ' ';
Biblioteca[0, 19, 3] = 'C';
Biblioteca[0, 20, 3] = 'o';
Biblioteca[0, 21, 3] = 'n';
Biblioteca[0, 22, 3] = 's';
Biblioteca[0, 23, 3] = 't';
Biblioteca[0, 24, 3] = 'r';
Biblioteca[0, 25, 3] = 'u';
Biblioteca[0, 26, 3] = 'c';
Biblioteca[0, 27, 3] = 'c';
Biblioteca[0, 28, 3] = 'i';
Biblioteca[0, 29, 3] = 'o';
Biblioteca[0, 30, 3] = 'n';

//Autor

Biblioteca[1, 0, 3] = 'M';
Biblioteca[1, 1, 3] = 'o';
Biblioteca[1, 2, 3] = 'n';
Biblioteca[1, 3, 3] = 't';
Biblioteca[1, 4, 3] = 'e';
Biblioteca[1, 5, 3] = 'n';
Biblioteca[1, 6, 3] = 'a';

//6073136005

Biblioteca[2, 0, 3] = '6';
Biblioteca[2, 1, 3] = '0';
Biblioteca[2, 2, 3] = '7';
Biblioteca[2, 3, 3] = '3';
Biblioteca[2, 4, 3] = '1';
Biblioteca[2, 5, 3] = '3';
Biblioteca[2, 6, 3] = '6';
Biblioteca[2, 7, 3] = '0';
Biblioteca[2, 8, 3] = '0';
Biblioteca[2, 9, 3] = '5';

//Disponible

Biblioteca[3, 0, 3] = '1';

//Harry Potter y el prisionero de Azkaban, J.K. Rowling, 8418173025, Disponible
Biblioteca[0, 0, 4] = 'H';
Biblioteca[0, 1, 4] = 'a';
Biblioteca[0, 2, 4] = 'r';
Biblioteca[0, 3, 4] = 'r';
Biblioteca[0, 4, 4] = 'y';
Biblioteca[0, 5, 4] = ' ';
Biblioteca[0, 6, 4] = 'P';
Biblioteca[0, 7, 4] = 'o';
Biblioteca[0, 8, 4] = 't';
Biblioteca[0, 9, 4] = 't';
Biblioteca[0, 10, 4] = 'e';
Biblioteca[0, 11, 4] = 'r';
Biblioteca[0, 12, 4] = ' ';
Biblioteca[0, 13, 4] = 'y';
Biblioteca[0, 14, 4] = ' ';
Biblioteca[0, 15, 4] = 'e';
Biblioteca[0, 16, 4] = 'l';
Biblioteca[0, 17, 4] = ' ';
Biblioteca[0, 18, 4] = 'p';
Biblioteca[0, 19, 4] = 'r';
Biblioteca[0, 20, 4] = 'i';
Biblioteca[0, 21, 4] = 's';
Biblioteca[0, 22, 4] = 'i';
Biblioteca[0, 23, 4] = 'o';
Biblioteca[0, 24, 4] = 'n';
Biblioteca[0, 25, 4] = 'e';
Biblioteca[0, 26, 4] = 'r';
Biblioteca[0, 27, 4] = 'o';
Biblioteca[0, 28, 4] = ' ';
Biblioteca[0, 29, 4] = 'd';
Biblioteca[0, 30, 4] = 'e';
Biblioteca[0, 31, 4] = ' ';
Biblioteca[0, 32, 4] = 'A';
Biblioteca[0, 33, 4] = 'z';
Biblioteca[0, 34, 4] = 'k';
Biblioteca[0, 35, 4] = 'a';
Biblioteca[0, 36, 4] = 'b';
Biblioteca[0, 37, 4] = 'a';
Biblioteca[0, 38, 4] = 'n';

//Autor

Biblioteca[1, 0, 4] = 'J';
Biblioteca[1, 1, 4] = '.';
Biblioteca[1, 2, 4] = 'K';
Biblioteca[1, 3, 4] = '.';
Biblioteca[1, 4, 4] = ' ';
Biblioteca[1, 5, 4] = 'R';
Biblioteca[1, 6, 4] = 'o';
Biblioteca[1, 7, 4] = 'w';
Biblioteca[1, 8, 4] = 'l';
Biblioteca[1, 9, 4] = 'i';
Biblioteca[1, 10 ,4] = 'n';
Biblioteca[1, 11, 4] = 'g';

//8418173025

Biblioteca[2, 0, 4] = '8';
Biblioteca[2, 1, 4] = '4';
Biblioteca[2, 2, 4] = '1';
Biblioteca[2, 3, 4] = '8';
Biblioteca[2, 4, 4] = '1';
Biblioteca[2, 5, 4] = '7';
Biblioteca[2, 6, 4] = '3';
Biblioteca[2, 7, 4] = '0';
Biblioteca[2, 8, 4] = '2';
Biblioteca[2, 9, 4] = '5';

//Disponible

Biblioteca[3, 0, 4] = '1';

int CantidadDeLibros = 0;
for (int l = 0; l < 1000; l++)
{
    if (Biblioteca[3, 0, l] == '0' || Biblioteca[3, 0, l] == '1')
    { 
        CantidadDeLibros++;
    }
}




//Operaciones:

//Agregar 1
//Prestar 2
//Devolver 3
//Buscar 4
//Listar 5
int EnMarcha = 1;
while (EnMarcha == 1)
{
    
    Console.WriteLine("Escriba un numero del 1 al 5 para hacer lo siguiente: ");
    Console.WriteLine("Agregar = 1");
    Console.WriteLine("Prestar = 2");
    Console.WriteLine("Devolver = 3");
    Console.WriteLine("Buscar = 4");
    Console.WriteLine("Listar = 5");

    int Accion = Convert.ToInt32(Console.ReadLine());

    if (Accion == 1)
    {
        Agregar();
        void Agregar()
        {




            Console.WriteLine("Inserte el título del libro que desees agregar: ");
            char[] AgregarTitulo = Console.ReadLine().ToCharArray();

            for (int i = 0; i < AgregarTitulo.Length; i++)
            {
                Biblioteca[0, i, CantidadDeLibros] = AgregarTitulo[i];
            }

            Console.WriteLine("Inserte el autor del libro que desees agregar: ");
            char[] AgregarAutor = Console.ReadLine().ToCharArray();

            for (int j = 0; j < AgregarAutor.Length; j++)
            {
                Biblioteca[1, j, CantidadDeLibros] = AgregarAutor[j];
            }

            Console.WriteLine("Inserte el ISBM-10 del libro que desees agregar: ");
            char[] AgregarIsbm = Console.ReadLine().ToCharArray();

            for (int k = 0; k < AgregarIsbm.Length; k++)
            {
                Biblioteca[2, k, CantidadDeLibros] = AgregarIsbm[k];
            }

            Console.WriteLine("Se ha añadido con exito el libro");
        }
    }


    if (Accion == 2)
    {
        Prestar();
        void Prestar()
        {
            Console.WriteLine("Libros que actualmente están disponibles:");

            for (int i = 0; i < CantidadDeLibros - 1; i++)
            {
                if (Biblioteca[3, 0, i] == '1')
                {
                    Console.WriteLine();
                    Console.Write(i + ". ");
                    for (int j = 0; j < 49; j++)
                    {
                        Console.Write(Biblioteca[0, j, i]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("¿Qué libro quieres? (ponga el número)");
            int LibroParaPrestar = Convert.ToInt32(Console.ReadLine());
            Biblioteca[3, 0, LibroParaPrestar] = '0';
            Console.WriteLine("El libro que has obtenido ya no está disponible en la biblioteca");
        }
    }


    if (Accion == 3)
    {
        Devolver();
        void Devolver()
        {
            for (int l = 0; l < 1000; l++)
            {
                if (Biblioteca[3, 0, l] == '0' || Biblioteca[3, 0, l] == '1')
                {
                    CantidadDeLibros++;
                }
            }
            Console.WriteLine("Libro(s) que puedes devolver:");

            for (int i = 0; i < CantidadDeLibros - 1; i++)
            {
                if (Biblioteca[3, 0, i] == '0')
                {
                    Console.WriteLine();
                    Console.Write(i + ". ");
                    for (int j = 0; j < 49; j++)
                    {
                        Console.Write(Biblioteca[0, j, i]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("¿Qué libro quieres? (ponga el número)");
            int LibroParaDevolver = Convert.ToInt32(Console.ReadLine());
            Biblioteca[3, 0, LibroParaDevolver] = '1';
            Console.WriteLine("El libro que has obtenido ya está disponible en la biblioteca");
        }
    }


    if (Accion == 4)
    {
        Buscar();
        void Buscar()
        {
            Console.WriteLine("¿Quieres buscar por título, autor o ISBM?");
            Console.WriteLine("Título = 1");
            Console.WriteLine("Autor = 2");
            Console.WriteLine("ISBM = 3");
            int BuscarPor = Convert.ToInt32(Console.ReadLine());
            if (BuscarPor == 1)
            {
                Console.WriteLine("Inserte el título del libro:");
                char[] BuscarTitulo = Console.ReadLine().ToCharArray();
                Console.WriteLine();
                for (int i = 0; i < CantidadDeLibros; i++)
                {
                    for (int j = 0; j < BuscarTitulo.Length; j++)
                    {
                        if (Biblioteca[0, j, i] == BuscarTitulo[j])
                        {
                            Console.Write(Biblioteca[0, j, i]);
                        }

                    } Console.WriteLine();
                    for (int j = 0; j < BuscarTitulo.Length; j++)
                    {
                        if (Biblioteca[0, j, i] == BuscarTitulo[j])
                        {
                            for (int k = 0; k < 49; k++)
                            {
                                Console.Write(Biblioteca[1, k, i]);
                            }
                        }

                    } Console.WriteLine();
                    for (int j = 0; j < BuscarTitulo.Length; j++)
                    {
                        if (Biblioteca[0, j, i] == BuscarTitulo[j])
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                Console.Write(Biblioteca[2, k, i]);
                            }
                        }
                    } Console.WriteLine();

                    for (int j = 0; j < BuscarTitulo.Length; j++)
                    {
                        if (Biblioteca[0, j, i] == BuscarTitulo[j])
                        {
                            if (Biblioteca[3, 0, i] == '1')
                            {
                                Console.WriteLine("Disponible");
                            }
                            else if (Biblioteca[3, 0, i] == '0')
                            {
                                Console.WriteLine("No disponible");
                            }

                        }

                    }



                }
            }
            if (BuscarPor == 2)
            {
                Console.WriteLine("Inserte el autor del libro:");
                char[] BuscarAutor = Console.ReadLine().ToCharArray();
                Console.WriteLine();
                for (int i = 0; i < CantidadDeLibros; i++)
                {
                    for (int j = 0; j < BuscarAutor.Length; j++)
                    {
                        if (Biblioteca[1, j, i] == BuscarAutor[j])
                        {
                            Console.Write(Biblioteca[0, j, i]);
                        }

                    }
                    Console.WriteLine();
                    for (int j = 0; j < BuscarAutor.Length; j++)
                    {
                        if (Biblioteca[1, j, i] == BuscarAutor[j])
                        {
                            for (int k = 0; k < 49; k++)
                            {
                                Console.Write(Biblioteca[1, k, i]);
                            }
                        }

                    }
                    Console.WriteLine();
                    for (int j = 0; j < BuscarAutor.Length; j++)
                    {
                        if (Biblioteca[1, j, i] == BuscarAutor[j])
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                Console.Write(Biblioteca[2, k, i]);
                            }
                        }
                    }
                    Console.WriteLine();

                    for (int j = 0; j < BuscarAutor.Length; j++)
                    {
                        if (Biblioteca[1, j, i] == BuscarAutor[j])
                        {
                            if (Biblioteca[3, 0, i] == '1')
                            {
                                Console.WriteLine("Disponible");
                            }
                            else if (Biblioteca[3, 0, i] == '0')
                            {
                                Console.WriteLine("No disponible");
                            }

                        }

                    }



                }
            }
            if (BuscarPor == 3)
            {
                Console.WriteLine("Inserte el título del libro:");
                char[] BuscarIsbm = Console.ReadLine().ToCharArray();
                Console.WriteLine();
                for (int i = 0; i < CantidadDeLibros; i++)
                {
                    for (int j = 0; j < BuscarIsbm.Length; j++)
                    {
                        if (Biblioteca[2, j, i] == BuscarIsbm[j])
                        {
                            Console.Write(Biblioteca[0, j, i]);
                        }

                    }
                    Console.WriteLine();
                    for (int j = 0; j < BuscarIsbm.Length; j++)
                    {
                        if (Biblioteca[2, j, i] == BuscarIsbm[j])
                        {
                            for (int k = 0; k < 49; k++)
                            {
                                Console.Write(Biblioteca[1, k, i]);
                            }
                        }

                    }
                    Console.WriteLine();
                    for (int j = 0; j < BuscarIsbm.Length; j++)
                    {
                        if (Biblioteca[2, j, i] == BuscarIsbm[j])
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                Console.Write(Biblioteca[2, k, i]);
                            }
                        }
                    }
                    Console.WriteLine();

                    for (int j = 0; j < BuscarIsbm.Length; j++)
                    {
                        if (Biblioteca[2, j, i] == BuscarIsbm[j])
                        {
                            if (Biblioteca[3, 0, i] == '1')
                            {
                                Console.WriteLine("Disponible");
                            }
                            else if (Biblioteca[3, 0, i] == '0')
                            {
                                Console.WriteLine("No disponible");
                            }

                        }

                    }



                }
            }
        }
    }


    if (Accion == 5)
    {
        Listar();
        void Listar()
        {
            for (int i = 0; i < CantidadDeLibros; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 49; j++)
                {
                    Console.Write(Biblioteca[0, j, i]);
                }
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine("¿Quieres seguir?");
    Console.WriteLine("Sí = 1");
    Console.WriteLine("No = 0");
    int UserInput = Convert.ToInt32(Console.ReadLine());
    if (UserInput == 0) 
    {
    EnMarcha = 0;
    }
}

Console.WriteLine();
Console.Write("He finalizado");


    
