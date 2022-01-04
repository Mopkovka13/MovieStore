using MovieStore.Interfaces;
using System;
using System.Collections.Generic;


namespace MovieStore.Models
{
    internal class Shop
    {
        private List<Showcase> _showcases = new List<Showcase>();
        private bool _isOpen = true;
        public void Open()
        {
            do
            {
                Menu();
            } while (_isOpen);
        }
        
        private void Menu()
        {
            
            Console.Write("1. Add showcase\n" +
                                "2. Show showcases\n" +
                                "3. Edit showcase\n" +
                                "4. Delete showcase\n" +
                                "5. Close programm\n");
            ConsoleKeyInfo operation = Console.ReadKey(true);
            switch (operation.Key)
            {
                case ConsoleKey.D1:
                    addShowcase();
                    break;
                case ConsoleKey.D2:
                    showShowcases();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Вы пошли назад");
                    /*
                     * Выберите витрину
                     * Поменять название
                     * Сменить Объём
                     * Добавить товар на витрину
                     * Выйти
                     */
                    break;
                case ConsoleKey.D4:
                    deleteShowcase();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("Programm is closed");
                    _isOpen = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Not found\n");
                    break;
            }
        }
        void addShowcase()
        {
            try
            {
                Console.Clear();
                Console.Write("Print name: ");
                string nameShowcase = Console.ReadLine();
                Console.Write("Print capacity: ");
                uint capacityShowcase = Convert.ToUInt32(Console.ReadLine());
                if (capacityShowcase < 1)
                    throw new Exception("Capacity < 1");
                Showcase showcase = new Showcase(nameShowcase, capacityShowcase);
                _showcases.Add(showcase);
                Console.Clear();
                Console.WriteLine("Showcase added\n");
            }
            catch
            {
                Console.WriteLine("You have entered incorrect data");
            }
        }
        void showShowcases()
        {
            if (_showcases.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No data\n");
            }
            else
            {
                Console.Clear();
                for (int i = 0; i < _showcases.Count; i++)
                {
                    _showcases[i].Show();
                }
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
            Console.Clear();
        }
        void deleteShowcase()
        {
            if (_showcases.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No data\n");
            }
            else
            {
                Console.Clear();
                for (int i = 0; i < _showcases.Count; i++)
                {
                    _showcases[i].Show();
                }
                Console.WriteLine("Enter the id");
                bool success = uint.TryParse(Console.ReadLine(), out uint deleteId);
                if (success && deleteId < _showcases.Count)
                {
                    for (int i = 0; i < _showcases.Count; i++)
                    {
                        if (_showcases[i].Id == deleteId)
                        {
                            _showcases.RemoveAt(i);
                            Console.Clear();
                            Console.WriteLine("showcase deleted\n");
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Does not exist\n");
                }

            }
        }
    }
}
