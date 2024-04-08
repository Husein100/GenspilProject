using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Genspil
{
    internal class CustomerInquiry
    {
        //Trin 1: Definere private feltvariabler, der gemmer customerName, pohoneNum, address, email,inquiry og game
        private string customerName;
        private int phoneNum;
        private string address;
        private string email;
        private string[] inquiry;
        private Game game;

        //Trin 2: Egenskaber, der giver adgang til de private feltvariabler customerName, pohoneNum,email, address, inquiry og game
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.All(char.IsLetter))
                {
                    customerName = value;
                }
                else
                {
                    throw new Exception("Name must contain only letters and cannot be empty");
                }
            }
        }

        public int PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; } 
        }

        public string Address
        {
            get { return address; }
            set { address = value; } 
        }

        public string[] Inquiry 
        {
            get { return inquiry; }
            set { inquiry = value; }
        }

        public Game Game 
        {
            get { return game; }
            set { game = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        //Trin 3: Constructor, der tager seks parametre (customerName, pohoneNum, address,email, inquiry og game)
        //        Bruger disse parameter til at oprette et nyt CustomerInquiry objekt.

        public CustomerInquiry(string customerName,int phoneNum, string address, string[]inquiry, Game game, string email )
        {

            //Trin 4: At tildele værdier til alle egenskaber (properties) i objektet ved hjælp af de parametre, som constructor modtager.
            CustomerName = customerName;
            PhoneNum=phoneNum;
            Address=address;
            Inquiry=inquiry;
            Game=game;
            Email=email;
        }

        //Metoden tager de forskellige oplysninger om en kunde, såsom navn, addresse....
        //og samler dem i en overskuelig og organiseret tekststreng.
        //dvs. metoden "formatterer" oplysningerne på en måde, der gør dem mere visuelt tiltalende og brugbare.
        public string MakeTitleForCustomerInquiry()

        {
            //En tekststreng, som består af værdien af hver af klassens properties adskilt med et semikolon (;) RETURNERES. 
            // Saml værdierne af hver egenskab i en tekststreng adskilt med et semikolon
            string titel = $"{CustomerName};{PhoneNum};{Address};{Inquiry};{Game};{Email}";

            // Returner den resulterende tekststreng
            return titel;
        }


        //Trin 1: Denne streng definerer den fulde placering på filsystemet, hvor filen "GameDataBase.txt" er gemt.

        private string filePath1 = @"C:\Users\ahefr\Desktop\Husein 1 swemester\Genspil\CustomerInquiry.txt";

        public CustomerInquiry()
        {

            if (!File.Exists(filePath1))

                File.Create(filePath1).Close();

        }

        //Trin 2: Vi  tilføjer information om kundeforespørgsel
        //Bruges til at tilføje information om et spil til en eksisterende
        //fil med spildata, hvilket tillader tilføjelse af flere spil uden at overskrive eksisterende data.
        public void AddCustomerInquiry(CustomerInquiry customerInq)
        {

            string inquiryString = string.Join(";", customerInq.Inquiry);

            string gameData = $"{customerInq.Game.Name};{customerInq.Game.Condition}";


            string customerIntquaryData = $"{customerInq.CustomerName};{customerInq.PhoneNum};{customerInq.Address};{inquiryString};{gameData};{customerInq.Email}";

            // Vi opretter en array med en enkelt streng, som indeholder de data, der skal tilføjes til filen.
            //Denne linje indeholder dataene fra et Game-objekt, formateret som en tekststreng gameData
            //Hvis filen allerede eksisterer, tilføjes gameData til slutningen af filen. Hvis filen ikke eksisterer,
            //oprettes den, og gameData indsættes som dens eneste linje.
            File.AppendAllLines(filePath1, new[] { customerIntquaryData });


        }



    }

}
