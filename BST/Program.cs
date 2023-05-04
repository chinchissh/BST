using System;

namespace BST//Лабораторная работа по Мищенко №9
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(); // Создаем новый экземпляр класса BinaryTree для представления дерева

            // Добавляем узлы в дерево с помощью ввода с консоли
            while (true)
            {
                Console.Write("Введите значение нового узла (для завершения введите слово - стоп): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "стоп")
                {
                    break;
                }
                int value = Convert.ToInt32(input);
                tree.Add(value);
            }

            Console.Write("Введите значение искомого узла: ");
            int key = Convert.ToInt32(Console.ReadLine()); // Считываем значение искомого узла с консоли
            Node found = tree.Search(key); // Ищем узел в дереве

            // Выводим результат поиска
            if (found != null)
            {
                Console.WriteLine("Узел со значением {0} найден.", key);
            }
            else
            {
                Console.WriteLine("Узел со значением {0} не найден.", key);
            }

            Console.ReadKey();
        }
    }
}
