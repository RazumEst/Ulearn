using System;


namespace Сортировка_массива__бинарная_сортировка
{
    //создаем мини-деревце Node.
    internal class Node<T> : IComparable
        where T : IComparable //этот интерфейc позволяет выполнять операции сравнения(<>=)
        //он нужен нам для того, чтобы понять, куда идти - влево, вправ. т.е. необходим при поиске.
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }
        //далее конструкторы
        public Node (T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

