using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }




        public static List<Person> GetPeoples()
        {
            var lst = new List<Person>();
            lst.Add(new Person()
            {
                Id=1,
                Name="Иван",
            Image="user.png",
            Age = 20});
            lst.Add(new Person()
            {
                Id = 2,
                Name = "Петр",
                Image = "user.png",
                Age = 22
            }); lst.Add(new Person()
            {
                Id = 3,
                Name = "Мария",
                Image = "user2.png",
                Age = 25
            }); lst.Add(new Person()
            {
                Id = 4,
                Name = "Анна",
                Image = "user2.png",
                Age = 15
            }); 
            lst.Add(new Person()
            {
                Id = 5,
                Name = "Максим",
                Image = "user.png",
                Age = 29
            }); 
            lst.Add(new Person()
            {
                Id = 6,
                Name = "Сергей",
                Image = "user.png",
                Age = 30
            });

            return lst;
        }
    }
}
