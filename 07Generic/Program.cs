using System;
using System.Collections.Generic;

namespace Generics
{
    class Repository<T>
    {
        private List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public List<T> GetAll()
        {
            return _items;
        }
    }
    class User { private string _name; public User(string name) => _name = name; public string SayMyName(){return _name;} }
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User("Хайзенберг");
            var user2 = new User("Соул Гудман");
            var user3 = new User("Джесси Пинкман");
            Repository<User> repository = new Repository<User>();
            repository.Add(user1);
            repository.Add(user2);
            repository.Add(user3);
            foreach (User user in repository.GetAll())
            {
                Console.WriteLine(user.SayMyName());
            }

        }
    }
}