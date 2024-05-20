using System.Security.Cryptography.X509Certificates;
using asignacionDos.Clases_Principales;

namespace asignacionDos.Menu.Registro
{
    internal class RegistroUsuario
    {
        public string nombreL {get;  set;}
        public string gmailL {get;  set;}
        public void Login()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(" \n                     B I B L I O T E C A \n \n   COMPLETE LOS CAMPOS PARA REGISTRARSE Y PODER ENTRAR");
            Console.ResetColor();
            System.Console.Write("\n \nNombre:");
            string nombreL = Console.ReadLine()!;
            System.Console.Write("Apellido:");
            string apellidoL = Console.ReadLine()!;
            System.Console.Write("Edad:");
            int edadL = int.Parse(Console.ReadLine()!);
            System.Console.Write("Gmail:");
            string gmailL = Console.ReadLine()!;

            MayorDeEdad verificacion = new MayorDeEdad();
            if (verificacion.EdadVerificacion(edadL))
            {
                 Usuario u = new Usuario(nombreL, apellidoL, edadL, gmailL);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Registro exitoso. Bienvenido {nombreL} \n \n ");
                Console.ResetColor();

                ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

                int currentColor = 0;

                while (true)
                {

                    Console.ForegroundColor = colors[currentColor];

                    Console.Write("\r                                                                  Pulse ENTER para salir ");

                    currentColor++;
                    if (currentColor >= colors.Length)
                    {
                        currentColor = 0;
                    }

                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                    
                    {
                        break;
                    }
                    System.Threading.Thread.Sleep(500);
                }
                Console.ResetColor();
                Console.Clear();
                MenuPrincipal men = new MenuPrincipal();
                men.MPrincipal(u);

            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(":( !!!!!!!! XXXXXXXXX \n Lo Siento! Debes ser mayor de edad para registrarte");
                Console.ResetColor();
 
            }

        }
    }
}