using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class BinaryTree
    {
        public Node Root { get; set; } // Корень дерева

        // Конструктор класса BinaryTree, устанавливающий начальное значение корня дерева как null
        public BinaryTree()
        {
            Root = null;
        }

        // Метод поиска узла в дереве
        public Node Search(int key)
        {
            Node current = Root; // Начинаем поиск с корня дерева
            while (current != null && current.Data != key)
            { // Пока не достигнуто конца дерева или не найден искомый узел
                if (key < current.Data)
                { // Если ключ меньше значения текущего узла, идем налево
                    current = current.Left;
                }
                else
                { // Иначе идем направо
                    current = current.Right;
                }
            }
            return current; // Возвращаем найденный узел или null, если узел не найден
        }

        // Метод добавления узла в дерево
        public void Add(int data)
        {
            Node newNode = new Node(data); // Создаем новый узел с заданным значением
            if (Root == null)
            { // Если корень дерева не установлен, устанавливаем его на новый узел
                Root = newNode;
                return;
            }
            Node current = Root; // Начинаем поиск места для вставки с корня дерева
            Node parent = null; // Запоминаем родительский узел
            while (true)
            {
                parent = current;
                if (data < current.Data)
                { // Если значение нового узла меньше значения текущего узла, идем налево
                    current = current.Left;
                    if (current == null)
                    { // Если достигнуто конца дерева, добавляем новый узел как левого дочернего узла родительского узла
                        parent.Left = newNode;
                        return;
                    }
                }
                else
                { // Иначе идем направо
                    current = current.Right;
                    if (current == null)
                    { // Если достигнуто конца дерева, добавляем новый узел как правого дочернего узла родительского узла
                        parent.Right = newNode;
                        return;
                    }
                }
            }
        }
    }
}

