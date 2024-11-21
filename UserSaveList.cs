using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class UserSaveList
    {
        private List<User> users;
        private int idCounter;
        private string PathFile;

        public UserSaveList(string file)
        {
            PathFile = file;
            LoadUser();
        }

        public void LoadUser()
        {
            if (File.Exists(PathFile))
            {
                using (StreamReader sr = new StreamReader(PathFile, Encoding.UTF8))
                {
                    var linesUser = JsonSerializer.Deserialize<List<User>>(sr.ReadToEnd());
                    users = linesUser ?? new List<User>();
                    idCounter = user.Count > 0 ? user.Count : 0;
                }
            }
        }
        public void SaveUserListAdding()
        {
            using (StreamWriter sw = new StreamWriter(PathFile, false, Encoding.UTF8))
            {
                var linesSaveList = JsonSerializer.Serialize(user);
                sw.Write(linesSaveList);
                Console.WriteLine("Users have been saved successfully.");
            }
        }

        public int IdCounter()
        {
            return ++idCounter;
        }
        public void AddingUser()
        {
            Console.Write("Enter User Name: ");
            string userName = Console.ReadLine();
            User userAdd = new User(IdCounter , userName);
            users.Add(userAdd);
            SaveUserListAdding();
        }
    }
}