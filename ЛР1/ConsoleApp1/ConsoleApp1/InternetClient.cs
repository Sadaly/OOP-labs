    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp1
    {
        class InternetClient
        {
            private string id;
            public string ID
            {
                get { return id; }
                set { id = value; }
            }
            public string name;
            private int age;
            public int Age
            {
                get { return age; }
                set { if (value >= 18) age = value; else age = -1; }
            }

            public bool is_male;
            public string login;
            private string password;
            public string Password
            {
                get { return password; }
                set { password = value; }
            }
            public InternetClient(string idT, string nameT, int ageT, bool isMaleT, string loginT, string paswwordT)
            {
                id = idT;
                name = nameT;
                age = ageT;
                is_male = isMaleT;
                login = loginT;
                password = paswwordT;
            }
            public InternetClient()
            {
                id = "EmptySpace";
                name = "EmptySpace";
                age = 0;
                is_male = true;
                login = "EmptySpace";
                password = "EmptySpace";
            }
            public static void ShowInfo(InternetClient client)
            {
                Console.WriteLine("Айди: " + client.id);
                Console.WriteLine("Имя: " + client.name);
                Console.WriteLine("Возраст: " + client.age);
                if (client.is_male)
                    Console.WriteLine("Пол: мужской");
                else
                    Console.WriteLine("Пол: женский");
                Console.WriteLine("Логин: " + client.login);
                Console.WriteLine("Пароль: " + client.password);
            }

        }
    }
