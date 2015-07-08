using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Factory
{
    static class Controller
    {
        private static dbFChocolate db = new dbFChocolate();
        private static string name, lastname, email;
        private static int age;
        private static int id;
        public static void CreatedUser()
        {
  
            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Last name: ");
                lastname = Console.ReadLine();

                Console.WriteLine("Age: ");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Email: ");
                email = Console.ReadLine();
            } while (name == "" || lastname == "");


            PersonProfile person = new PersonProfile(name,lastname,age,email);
            db.user_profile.Add(person);
            db.PayChocolates.Add(person.money);
            db.SaveChanges();
        }
        private static IQueryable<PersonProfile> Find_PersonByName()
        {
            Console.WriteLine("Buscar Perfil: ");
            name = Console.ReadLine();
            var persons = from person in db.user_profile where person.FirstName.Contains(name) select person;
            return persons;
        }

        public static void ShowUserInfo()
        {
            var persons =  Find_PersonByName();
            foreach (var p in persons)
            {
                Console.WriteLine( p.FirstName + " " + p.LastName + ", Cantidad pagada: " + p.money.mount + " Falta por pagar " +  p.money.oweMoney);
            }
        }

        public static void UserPayMoney()
        {
            var persons = Find_PersonByName();

            Console.WriteLine("Cuanto pago: ");
            int pay = int.Parse(Console.ReadLine());
            foreach (var p in persons)
            {
                if (p.money.oweMoney > 0)
                {
                    p.money.oweMoney = p.money.oweMoney - pay;
                    p.money.mount = p.money.mount + pay;
                    db.Entry(p).State = EntityState.Modified;
                }
                else
                {
                    p.money.mount = p.money.mount + pay;
                    db.Entry(p).State = EntityState.Modified;                   
                }
            }
            db.SaveChanges(); 
            
        }
        public static void UserOweMoney() 
        {
            var persons = Find_PersonByName();
            Console.WriteLine("Cuanto debe: ");
            int owe = int.Parse(Console.ReadLine());
            foreach (var p in persons)
            {
                p.money.oweMoney = p.money.oweMoney + owe;
                db.Entry(p).State = EntityState.Modified;
            }
            db.SaveChanges();
        }
        //private static void SelectMoneyByid(int id)
        //{
        //    var mount = from money in db.PayChocolates where money.IdMoney == id  select money;
        //    foreach (var i in mount)
        //    {
        //        Console.Write(i.mount);
        //    }
            
    }

}
