using System;

namespace Genspil
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the BoardGame Manager");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please press (1) to login with your name and password or (2) to create a user account:");
            
            string choice=Console.ReadLine();
            
            switch(choice)
            {

                //Login 
                case "1":
                    break;
                //Create a user account
                case "2":
                    break;
            }


                




            //// Brugerindtastning for at oprette en bruger kun med navn og adgangskode
            //Console.WriteLine("\nCreate a user with  name and password:");
            //Console.Write("Enter name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter password: ");
            //string password = Console.ReadLine();
            //Random random = new Random();
            //int randomIdNum = random.Next(1, 10000);
            //string id=randomIdNum.ToString();
            //// Opret en ny bruger kun med navn og adgangskode
            //User user2 = new User(name, id,password);
            //Console.WriteLine($"User created: Name={user2.Name}, Id={user2.Id}, Password={user2.Password}");

            ////Tilføj bruger til filen
            //user2.AddUser(user2);

            //Console.WriteLine("Bruger tilføjet til filen.");

            //Console.ReadLine();


            // Trin 1: Indsaml oplysninger fra brugeren, oplysninger som skal bruges til at oprette en CustomerInquiry objekt
            Console.WriteLine("Indtast kundens navn:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Indtast kundens telefonnummer:");
            int phoneNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Indtast kundens adresse:");
            string address = Console.ReadLine();

            Console.WriteLine("Indtast kundens e-mail:");
            string email = Console.ReadLine();

            // Forespørgsler adskilt af semikolon
            Console.WriteLine("Indtast kundens forespørgsel:");
            string[] inquiry = Console.ReadLine().Split(';');

            Console.WriteLine("Brætspil navn:");
            string gameName = Console.ReadLine();

            Console.WriteLine("Brætspil stand:");
            string gameCondition = Console.ReadLine();

            // Opret et nyt Game-objekt
            Game game = new Game(gameName, gameCondition);

            // Opret en ny CustomerInquiry med brugerens input
            CustomerInquiry customerInquiry = new CustomerInquiry(customerName, phoneNum, address, inquiry, game, email);

            // Tilføj kundeforespørgslen til filen
            customerInquiry.AddCustomerInquiry(customerInquiry);

            Console.WriteLine("Kundeforespørgsel tilføjet til filen.");

            Console.ReadLine();
        }
    }
}


