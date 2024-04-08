using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.IO;

namespace Genspil
{
    internal class DataHandler
    {
        // Filstien til spildatabasen
        private string filePath = @"C:\Users\ahefr\Desktop\Husein 1 swemester\Genspil\GameDataBase.txt";

        // Konstruktør til at sikre, at filen eksisterer
        public DataHandler()
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
        }

        // Metode til at tilføje et spil til databasen
        public void AddGame(Game game)
        {
            // Opretter en tekststreng med spiloplysninger adskilt af semikolon
            string gameData = $"{game.Name};{game.Genre};{game.NumberOfPlayers};{game.Condition};{game.Price}";

            // Tilføjer spildata til filen
            File.AppendAllLines(filePath, new[] { gameData });
        }

        // Metode til at indlæse spil fra databasen
        public Game[] LoadGames()
        {
            // Liste til at gemme indlæste spil
            List<Game> gameList = new List<Game>();

            // Åbner filen og læser spildata
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;

                // Læser hver linje af filen
                while ((line = sr.ReadLine()) != null)
                {
                    // Opdeler linjen i dele adskilt af semikolon
                    string[] parts = line.Split(';');

                    // Tildeler hver del til de relevante attributter for et spil og opretter et nyt Game-objekt
                    string name = parts[0];
                    string genre = parts[1];
                    int numberOfPlayers = int.Parse(parts[2]);
                    string condition = parts[3];
                    double price = double.Parse(parts[4]);

                    // Tilføjer det oprettede spil til listen af spil
                    gameList.Add(new Game(name, genre, numberOfPlayers, condition, price));
                }
            }

            // Returnerer listen af spil som et array
            return gameList.ToArray();
        }

        // Metode til at fjerne et spil fra databasen
        public void RemoveGame(string gameNameToRemove)
        {
            // Liste til at gemme indlæste spil
            List<Game> gameList = new List<Game>();

            // Åbner filen og læser spildata
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;

                // Læser hver linje af filen
                while ((line = sr.ReadLine()) != null)
                {
                    // Opdeler linjen i dele adskilt af semikolon
                    string[] parts = line.Split(';');

                    // Tildeler navnet til det første element (spilnavn)
                    string name = parts[0];

                    // Hvis navnet på det aktuelle spil ikke matcher navnet på spillet, der skal fjernes, tilføjes det til listen af spil
                    if (name != gameNameToRemove)
                    {
                        string genre = parts[1];
                        int numberOfPlayers = int.Parse(parts[2]);
                        string condition = parts[3];
                        double price = double.Parse(parts[4]);

                        gameList.Add(new Game(name, genre, numberOfPlayers, condition, price));
                    }
                }
            }

            // Åbner filen til skrivning
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                // Gennemgår hver spil i den opdaterede liste af spil og skriver dem til filen i det rigtige format
                foreach (Game g in gameList)
                {
                    sw.WriteLine($"{g.Name};{g.Genre};{g.NumberOfPlayers};{g.Condition};{g.Price}");
                }
            }
        }
    }
}

