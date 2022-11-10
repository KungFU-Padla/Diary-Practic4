namespace Diary_of_a_madman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            int position = 1;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.Clear();
                    Menu();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.Clear();
                    Menu();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                else if (key.Key == ConsoleKey.Enter && position == 0)
                {
                        Zametka_1();
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    Menu();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                else if (key.Key == ConsoleKey.Enter && position == 1)
                {
                    Zametka_2();
                }
                else if (key.Key == ConsoleKey.Enter && position == 2)
                {
                    Zametka_3();
                }
                else if (key.Key == ConsoleKey.Enter && position == 3)
                {
                    Zametka_4();
                }
                else if (key.Key == ConsoleKey.Enter && position == 4)
                {
                    Zametka_5();
                }
                



            }
            //////////////////////////////////////////////////////////////////////
            static void Menu()


            {
                Console.WriteLine("  1.Заметка");
                {

                }

                Console.WriteLine("  2.Заметка");
                {



                }
                Console.WriteLine("  3.Заметка");

                {

                }

                Console.WriteLine("  4.Заметка");

                {

                }


                Console.WriteLine("  5.Заметка");

                {

                }


            }

            static void Zametka_1()
            {
                Console.Clear();
                Заметка page1 = new Заметка();

                page1.Name = "  Золоторудная жила истощилась";
                page1.Description = "  Так точно!";
                page1.EndDate = new DateTime(2022, 11, 01); 
                Console.WriteLine(page1.Name);
                Console.WriteLine(page1.Description);
                Console.WriteLine(page1.EndDate);
            }
            static void Zametka_2()
            {
                Console.Clear();
                Заметка page2 = new Заметка();

                page2.Name = "  Бараки достроены, шеф!";
                page2.Description = "  Принято!"; 
                page2.EndDate = new DateTime(2022, 11,02);
                Console.WriteLine(page2.Name);
                Console.WriteLine(page2.Description);
                Console.WriteLine(page2.EndDate);
            }
            static void Zametka_3()
            {
                Console.Clear();
                Заметка page3 = new Заметка();

                page3.Name = "  Бараки достроены, шеф!";
                page3.Description = "  Принято!";
                page3.EndDate = new DateTime(2022, 11, 03);
                Console.WriteLine(page3.Name);
                Console.WriteLine(page3.Description);
                Console.WriteLine(page3.EndDate);
            }
            static void Zametka_4()
            {
                Console.Clear();
                Заметка page4 = new Заметка();

                page4.Name = "  Бараки достроены, шеф!";
                page4.Description = "  Принято!";
                page4.EndDate = new DateTime(2022, 11, 04);
                Console.WriteLine(page4.Name);
                Console.WriteLine(page4.Description);
                Console.WriteLine(page4.EndDate);
            }
            static void Zametka_5()
            {
                Console.Clear();
                Заметка page5 = new Заметка();

                page5.Name = "  Бараки достроены, шеф!";
                page5.Description = "  Принято!";
                page5.EndDate = new DateTime(2022, 11, 05);
                Console.WriteLine(page5.Name);
                Console.WriteLine(page5.Description);
                Console.WriteLine(page5.EndDate);
            }


        }
    }

}