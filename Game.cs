using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Genspil
{
    internal class Game
    {

        // //Trin 1: Definere private feltvariabler, der gemmer name, genre.....
        private string name;
        private string genre;
        private int numberOfPlayers;
        private string condition;
        private double price;



        //Egenskaber, der giver adgang til de private feltvariabler
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int NumberOfPlayers
        {
            get { return numberOfPlayers; }
            set { numberOfPlayers = value; }
        }

        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        //Trin 3: Constructor, der tager fem parametre (name, genre..........)
        //        Bruger disse parameter til at oprette et nyt Game objekt.

        public Game(string name, string genre, int numberOfPlayers, string condition, double price)
        {
            // Set værdierne af feltvariablerne baseret på de modtagne parametre
            this.Name = name;
            this.Genre = genre;
            this.NumberOfPlayers = numberOfPlayers;
            this.Condition = condition;
            this.Price = price;
        }

        //Constructor med 2 parameter navn og condition
        public Game(string name, string condition)
        {
            // Set værdierne af feltvariablerne baseret på de modtagne parametre
            this.Name = name;
            this.Condition = condition;
            
        }

        //Trin 4:
        //Metoden tager de forskellige oplysninger, såsom navn, genre....
        //og samler dem i en overskuelig og organiseret tekststreng.
        //dvs. metoden "formatterer" oplysningerne på en måde, der gør dem mere visuelt tiltalende og brugbare.
        public string MakeTitleForGame()

        {
            //En tekststreng, som består af værdien af hver af klassens properties adskilt med et semikolon (;) RETURNERES. 
            // Saml værdierne af hver egenskab i en tekststreng adskilt med et semikolon
            string titel = $"{Name};{Genre};{NumberOfPlayers};{Condition};{Price}";

            // Returner den resulterende tekststreng
            return titel;
        }




    }




}
