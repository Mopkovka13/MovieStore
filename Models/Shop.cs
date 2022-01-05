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
            _showcases.Add(new Showcase("Action", 10));
            _showcases.Add(new Showcase("Drama", 150));
            _showcases.Add(new Showcase("Lama", 12));
            do
            {
                Menu();
            } while (_isOpen);
        }
        
        private void Menu()
        {
            Console.Write("1. Add showcase\n" +
                                "2. Show showcases\n" +
                                "3. Show showcases with product\n" +
                                "4. Edit showcase\n" +
                                "5. Delete showcase\n" +
                                "6. Close programm\n");
            ConsoleKeyInfo operation = Console.ReadKey(true);
            switch (operation.Key)
            {
                case ConsoleKey.D1:
                    AddShowcase();
                    break;
                case ConsoleKey.D2:
                    ShowShowcases();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    for(int i = 0; i < _showcases.Count;i++)
                    {
                        _showcases[i].Show();
                        _showcases[i].ShowProducts();
                    }
                    Console.Write("Press any key...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.D4:
                    EditShowcase();
                    break;
                case ConsoleKey.D5:
                    DeleteShowcase();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("Programm is closed");
                    _isOpen = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Not found\n");
                    break;
            }
        }
        #region ImplementationMenu
        void AddShowcase()
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
        void ShowShowcases()
        {
            if (_showcases.Count == default)
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
                Console.Write("Press any key...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        void EditShowcase()
        {
            if(_showcases.Count== default) // Есть ли записи ?
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
                Console.Write("Choose the showcase (Id): ");
                bool success = uint.TryParse(Console.ReadLine(), out uint chooseShowcase);
                if (!success || chooseShowcase < 0) //Проверка на ввод
                {
                    Console.Clear();
                    Console.WriteLine("Vi vveli huynu\n");
                }
                else
                {
                    int indexShowcase = -1;
                    for(int i = 0; i < _showcases.Count;i++) //(Поиск по id, id может быть не последовательным)
                    {
                        if(_showcases[i].Id==chooseShowcase)
                        {
                            indexShowcase = i;
                        }   
                    }
                    if(indexShowcase == -1) //Если не нашлась запись 
                    {
                        Console.Clear();
                        Console.WriteLine("Not found\n");
                    }
                    else //Menu
                    {
                        Console.Clear();
                        _showcases[indexShowcase].Show();
                        _showcases[indexShowcase].ShowProducts();
                        Console.WriteLine("1. Edit name\n2. Edit capacity\n3. Add product\n4. Delete product\nAny key for exit");

                        ConsoleKeyInfo operation = Console.ReadKey(true);
                        switch (operation.Key)
                        {
                            case ConsoleKey.D1:
                                Console.Clear();
                                Console.Write("Print the name: ");
                                _showcases[indexShowcase].Name = Console.ReadLine();
                                break;
                            case ConsoleKey.D2:
                                Console.Write("Print the capacity: ");
                                _showcases[indexShowcase].Capacity = Convert.ToUInt32(Console.ReadLine());
                                break;
                            case ConsoleKey.D3:
                                _showcases[indexShowcase].AddProducts();
                                break;
                            case ConsoleKey.D4:
                                Console.WriteLine("new product");
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Not found\n");
                                break;
                        }
                    }
                }
            }
        }
        void DeleteShowcase()
        {
            if (_showcases.Count == default)
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
        #endregion
    }
}
