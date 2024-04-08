using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil
{
    using System;
    using System.IO;
    using System.Linq;

    internal class User
    {
        private string name;
        private string id;
        private string password;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.All(char.IsLetter))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name must only contain letters and cannot be empty");
                }
            }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(string name, string id, string password)
        {
            Name = name;
            Id = id;
            Password = password;
        }

        public User(string name, string password)
        {
            Name = name;
            Id = "Unknown";
            Password = password;
        }

        private string filePath1 = @"C:\Users\ahefr\Desktop\Husein 1 swemester\Genspil\UserDataBase.txt";

        public User()
        {
            if (!File.Exists(filePath1))
            {
                File.Create(filePath1).Close();
            }
        }

        public void AddUser(User user)
        {
            string userData = $"{user.Name};{user.Id};{user.Password}";

            File.AppendAllLines(filePath1, new[] { userData });
        }
    }













}

