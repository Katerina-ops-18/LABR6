using System;
using Firstlab.Classes;

namespace Firstlab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] selection = {"Створити","Відкрити","Редагувати"};
            string[] doctype = {"txt","dat"};

            while (true)
            {
                Console.WriteLine(new string('-',30));
                Console.Write("Введіть шлях до документу: ");
                string path = Console.ReadLine();
                Console.WriteLine(new string('-', 30));


                //Файл формату .txt або .dat
                AbstractHandler file;

                Console.WriteLine("Виберіть тип документу");
                for (int i = 0; i < doctype.Length; i++)
                    Console.WriteLine($"{i + 1}.{doctype[i]}");
                Console.Write("---> ");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        file = new TxtFile(path);
                        break;
                    case 2:
                        file = new DatFile(path);
                        break;
                    default:
                        file = null;
                        break;
                }
                Console.WriteLine(new string('-', 30));

                Console.WriteLine("Виберіть, що зробити з документом");
                for (int i = 0; i < selection.Length; i++)
                    Console.WriteLine($"{i + 1}.{selection[i]}");
                Console.Write("---> ");
                int m = Convert.ToInt32(Console.ReadLine());

                switch (m)
                {
                    case 1:
                        file.Create();
                        break;
                    case 2:
                        file.Open();
                        break;
                    case 3:
                        file.Edit();
                        break;
                }
                Console.WriteLine(new string('-', 30));

                Console.WriteLine("Для продовження натисніть ENTER, щоб увійти введіть Q");
                Console.Write("--->");
                string exit = Console.ReadLine();
                if (exit == "Q" || exit == "q")
                    break;
            }
        }
    }
}
