using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string Tecla = "";

            while(Tecla != "0")
            {
                
                Console.WriteLine("Presione ( 1 ) Crear perfil una persona:");
                Console.WriteLine("Presione ( 2 ) Buscar perfil de una persona:");
                Console.WriteLine("Presione ( 3 ) Agregar a perfil un pago:");
                Console.WriteLine("Presione ( 4 ) Agregar a deuda a perfil: ");
                Console.WriteLine("                                             Presione ( 0 ) Parasalir");
                Tecla = Console.ReadLine();

                switch (Tecla) 
                {
                    case "1":
                        Controller.CreatedUser();
                        Tecla = "";
                        break;
                    case "2":
                        Controller.ShowUserInfo();
                        Tecla = "";
                        break;
                    case "3":
                        Controller.UserPayMoney();
                        Tecla = "";
                        break;
                    case "4":
                        Controller.UserOweMoney();
                        Tecla = "";
                        break;
                }
                //Console.Clear();
            }

            Console.WriteLine("Exit");
            Console.ReadLine();
            
        }
    }
}
