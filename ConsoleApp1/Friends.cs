using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Person
    {
        string name;    
        string nickName;    
        int age;
        string pet;

        public static Person Default => new Person("No name", "No nick name", 0, null);

        public Person (string name, string nickName, int age, string pet)
        {
            Name = name;
            NickName = nickName;
            Age = age;
            Pet = pet;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    name = default;
                    return;
                }
                name = value;
            }
        }

        public override string ToString()
        {
            string info = $"{Name} ({NickName}) is {Age} old.";

            if (!string.IsNullOrEmpty(Pet))
                info += $" He/She has {Pet} pet.";

            return info;
        }

        public void Update(string name = null, string nickName = null, int age = int.MinValue, string pet = null)
        {
            if (!string.IsNullOrEmpty(name))
                Name = name;

            if (!string.IsNullOrEmpty(nickName))
                NickName = nickName;

            if (age != int.MinValue)
                Age = age;

            if (!string.IsNullOrEmpty(pet))
                Pet = pet;
        }

        public string NickName
        {
            get
            {
                return nickName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    nickName = default;
                    return;
                }
                nickName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    age = default;
                    Console.WriteLine("Age cannot be less than 0.");
                    return;
                }
                else if (value >= 90)
                {
                    Console.WriteLine("Your friend must be very old.");
                }
                age = value;
            }
        }

        public string Pet
        {
            get
            {
                return pet;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    pet = default;
                    return;
                }
                pet = value;
            }
        }
    }

    internal class Friends
    {
        static List<Person> friends = new List<Person>();

        public static void Run()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("This is the Friends program");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine("Description");
            Console.WriteLine("This program let's you to add, remove, update a friends info or list friends.");
            Console.WriteLine();

            Console.WriteLine("Actions");
            Console.WriteLine("list: show a list of friends.");
            Console.WriteLine("add: allows you to add a friend.");
            Console.WriteLine("update: allows you to update the info a friend using either name or nickname.");
            Console.WriteLine("remove: allows you to remove a friend from the list using either name or nickname.");
            Console.WriteLine("end: this will end the game.");
            Console.WriteLine();

            bool endLoop = false;
            string action;
            string[] actions = new string[]
            {
                "add", "remove", "update", "list"
            };

            do
            {
                Console.WriteLine();
                Console.Write("What action do you want to perform: ");
                action = Console.ReadLine();

                switch (action.ToLower())
                {
                    case "add":
                        Console.WriteLine("You want to add a friend.");
                        AddFriend();
                        break;
                    case "remove":
                        Console.WriteLine("You want to remove a friend from the list.");
                        RemoveFriend();
                        break;
                    case "update":
                        Console.WriteLine("You want to update the info of a friend.");
                        UpdateFriend();
                        break;
                    case "list":
                        Console.WriteLine("You want to list your friends.");
                        ListFriends();
                        break;
                    case "end":
                        Console.WriteLine("You ended the game");
                        endLoop = true;
                        break;
                    default:
                        Console.WriteLine("You want to add a friend");
                        break;

                }

            } while (!endLoop);


            Console.ReadLine();
        }

        static void AddFriend()
        {
            Console.WriteLine();
            string name = GetStringFromUser(message: "What is the name of your friend");
            string nickName = GetStringFromUser(message: "What is his/her nick name");
            (_, int age) = MainClass.GetIntFromUser(message: "What is his/her age: ");
            string pet = GetStringFromUser(message: "Does your friend have a pet? What is it", false);

            friends.Add(new Person(name, nickName, age, pet));

            Console.WriteLine($"Your friend with name: {name} has beed added to the list.");
        }

        static void RemoveFriend()
        {
            Console.WriteLine();
            Console.Write("Enter the name or nick name of the friend you want to remove: ");
            string name = Console.ReadLine();

            Person friend = friends.Find(x => x.Name == name || x.NickName == name);

            if (friend == null)
            {
                Console.WriteLine($"None of your friends has {name} as name or nick name.");
                return;
            }

            friends.Remove(friend);

            Console.WriteLine(friend);
            Console.WriteLine("Your friend has been removed.");
        }

        static void UpdateFriend()
        {
            Console.WriteLine();
            Console.Write("Enter the name or nick name of the friend whose info you want to update: ");
            string name = Console.ReadLine();

            Person friend = friends.Find(x => x.Name == name || x.NickName == name);

            if (friend.Name == "No name")
            {
                Console.WriteLine($"None of your friends has {name} as name or nick name.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("To update a field, type \"yes\". Any other input will be regarded as \"no\".");

            name = UpdateFriendStringField("Do you want to update the name?", "name");

            string nickName = UpdateFriendStringField("Do you want to update the nick name?", "nick name");

            Console.Write("Do you want to update the age? ");
            bool update = Console.ReadLine().ToLower() == "yes";

            int age = int.MinValue;
            if (update)
                (_, age) = MainClass.GetIntFromUser("Enter new age: ");

            Console.Write("Do you want to update the pet? ");
            update = Console.ReadLine().ToLower() == "yes";

            string pet = null;
            if (update)
                pet = GetStringFromUser("Enter new name");

            friend.Update(name, nickName, age, pet);

            Console.WriteLine(friend);
            Console.WriteLine("Your friend's info has been updated.");
        }

        static string UpdateFriendStringField(string message, string field)
        {
            string updatedField = null;
            if (ShouldUpdateField(message))
                updatedField = GetStringFromUser($"Enter new {field.ToLower()}");

            return updatedField;
        }

        static int UpdateFriendIntField(string message, string field)
        {
            int updatedField = int.MinValue;
            if (ShouldUpdateField(message))
                updatedField = MainClass.GetIntFromUser($"Enter new {field.ToLower()}").Item2;

            return updatedField;
        }

        static bool ShouldUpdateField(string message)
        {
            Console.WriteLine();
            Console.Write($"{message} ");
            return Console.ReadLine().ToLower() == "yes";
        }

        static string GetStringFromUser(string message, bool strict = true)
        {
            bool continueLoop = true;
            string input = null;
            do
            {
                Console.Write($"{message}: ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input) && strict)
                {
                    Console.WriteLine();
                    Console.WriteLine("You are required to provide this info.");
                    Console.WriteLine();
                    continue;
                }

                continueLoop = false;
            } while (continueLoop);

            return input;
        }

        static void ListFriends()
        {
            if (friends.Count < 1)
            {
                Console.WriteLine();
                Console.WriteLine("You do not have any friends listed.");
                Console.WriteLine();
                return;
            }

            Console.WriteLine();
            foreach (var item in friends)
            {
                Console.WriteLine();
                Console.WriteLine("----------------");
                Console.WriteLine();
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Nick Name: {item.NickName}");
                Console.WriteLine($"Age: {item.Age}");
                if (!string.IsNullOrEmpty(item.Pet))
                    Console.WriteLine($"Pet: {item.Pet}");

                Console.WriteLine();
                Console.WriteLine("----------------");
                Console.WriteLine();
            }
        }
    }
}