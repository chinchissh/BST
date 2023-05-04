using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class Node
    {
        public int Data { get; set; } // Значение узла
        public Node Left { get; set; } // Левый дочерний узел
        public Node Right { get; set; } // Правый дочерний узел

        // Конструктор класса Node, принимающий значение узла
        public Node(int data)
        {
            Data = data; // Устанавливаем значение узла
            Left = null; // Устанавливаем начальное значение левого дочернего узла как null
            Right = null; // Устанавливаем начальное значение правого дочернего узла как null
        }
    }
}
