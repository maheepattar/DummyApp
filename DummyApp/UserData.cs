using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyApp
{
    public class UserData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public List<UserData> GetUserData()
        {
            List<UserData> userDatas = new List<UserData>()
            {
            new UserData{ Id = 1, Name = "A", Salary = 500},
            new UserData{ Id = 2, Name = "B", Salary = 600},
            new UserData{ Id = 3, Name = "C", Salary = 800},
            new UserData{ Id = 4, Name = "D", Salary = 800},
            new UserData{ Id = 5, Name = "E", Salary = 900} };
            return userDatas;
        }
    }
}
