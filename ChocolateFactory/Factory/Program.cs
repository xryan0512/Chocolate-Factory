using System;
using System.Collections.Generic;
using System.Linq;

namespace Factory
{
    class Program
    {
        public static string Tecla = "";
        static void Main(string[] args)
        {
            string Tecla = "";
            while(Tecla != "0")
            {
                
                Console.WriteLine("Presione ( 1 ) Crear perfil una persona:");
                Console.WriteLine("Presione ( 2 ) Buscar perfil de una persona:");
                Console.WriteLine("                                             Presione ( 0 ) Para salir");
                Tecla = Console.ReadLine();

                switch (Tecla) 
                {
                    case "1":
                        Controller.CreatedUser();
                        SecondMenu();
                        Tecla = "";
                        break;
                    case "2":
                        Controller.ShowUserInfo();
                        SecondMenu();
                        Tecla = "";
                        break;

                }
                //Console.Clear();
            }

            Console.WriteLine("Exit");
            Console.ReadLine();
            
        }

        public static void SecondMenu() 
        {
            Console.WriteLine("Presione ( 1 ) Agregar a perfil un pago:");
            Console.WriteLine("Presione ( 2 ) Agregar a deuda a perfil: ");
            Console.WriteLine("                                             Presione ( 0 ) Para ir  Atras");
            Tecla = Console.ReadLine();
            switch (Tecla) 
            {
                case "1":
                        Controller.UserPayMoney();
                        Tecla = "";
                        break;
                case "2":
                        Controller.UserOweMoney();
                        Tecla = "";
                        break;
            }
            
        }
    }
}
