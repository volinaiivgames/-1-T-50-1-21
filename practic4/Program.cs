using System;
using System.Collections.Generic;

namespace practic4
{
    class Program
    {
        static int StartPage = 2;
        static int PositionPage = 2;
        static bool ActivePage = false;
        static List<Pages> ListPages = new List<Pages>();
        static List<Pages> ListPagesGarage = new List<Pages>();
        static void Main(string[] args) {
            ListPages.Add(new Pages("Придти на пары", "Со первой по пятую", new DateTime()));
            ListPages.Add(new Pages("Сходить в гараж", "", new DateTime()));
            ListPagesGarage.Add(new Pages("Проверить практические", "", new DateTime()));
            //ListPages.Add(new Pages("Сходить в гараж", "", new DateTime()));
            Open();
        }

        static void Open()
        {
            Console.Clear();
            ActivePage = false;
            DateTime date = new DateTime();
            Console.WriteLine($"Выбрана дата {date}");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < ListPages.Count; i++)
            {
                Console.WriteLine($"  {i+1}. {ListPages[i].Name}");
            }

            setCursor();
            while (!Console.KeyAvailable) setCursor();
        }

        static void setCursor()
        {
            if (!ActivePage)
            {
                Console.SetCursorPosition(0, PositionPage);
                Console.WriteLine("->");
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow && PositionPage >= StartPage && !ActivePage)
            {
                PositionPage--;
                Console.SetCursorPosition(0, PositionPage);
                Console.WriteLine("->");
                Open();
            }
            else if (key.Key == ConsoleKey.DownArrow && !ActivePage)
            {
                PositionPage++;
                Console.SetCursorPosition(0, PositionPage);
                Console.WriteLine("->");
                Open();
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                if (!ActivePage) Enter();
                else Open();
                return;
            }
        }
        static void Enter()
        {
            Console.Clear();
            int next = PositionPage - StartPage;
            if (next == 0)
            {
                Pages page = ListPages[next];
                Console.WriteLine($"{page.Name}");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Описание: {page.Description}");
                Console.WriteLine($"Дата: {page.Date}");
                ActivePage = true;
            }
            else if(next == 1)
            {
                Pages page = ListPages[1];
                ActivePage = true;
            }
        }
    }
}
