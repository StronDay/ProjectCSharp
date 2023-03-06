using System;
using System.Reflection;

namespace MyList
{
    class MyList<Type>
    {
        private Type[] _data;

        private uint _size;
        private uint _capacity;

        public uint Size { private set { _size = value; } get => _size; }
        public uint Capacity
        {
            get => _capacity;

            set
            {
                if (value < _size) 
                {
                    Console.WriteLine("#### Err: The capacity cannot be smaller than the size! ####");
                    return;
                }

                if (value != _size)
                {
                    if (value > 0)
                    {
                        _capacity = value;
                        Type[] new_data = new Type[_capacity];

                        if (_size > 0)
                        {
                            for (uint i = 0; i < _size; i++)
                            {
                                new_data[i] = _data[i];
                            }
                        }

                        _data = new_data;
                    }
                }
            }
        }

        public MyList() 
        {
            _capacity = 1;
            _size = 0;

            _data = new Type[_capacity];
        }

        public MyList(uint capacity) 
        {
            _capacity = capacity;
            _size = 0;

            _data = new Type[_capacity];
        }

        public MyList(uint capacity, Type item)
        {
            Capacity = capacity;
            _size = _capacity;

            _data = new Type[_capacity];
            for (int i = 0; i < _size; i++) 
            {
                _data[i] = item;
            }
        }

        //добавление нового элемента в список;
        public void Add(Type item)
        {
            if (_size < _capacity)
            {
                _data[_size++] = item;
                return;
            }
            else
            {
                AddWithResize(item);
            }
            
        }

        public void AddWithResize(Type item)
        {
            Capacity *= 2;
            _data[_size++] = item;
        }

        public void Print() 
        {
            for (uint i = 0; i < _size; i++)
            {
                Console.WriteLine($"[{i}]: {_data[i]}");
            }
        }
        
        //копирует список в массив array;
        public void CopyTo(Type[] array) { /*TODO*/ }

        //удаляет из списка все элементы;
        public void Clear() { /*TODO*/ }

        //изменяет порядок элементов;
        public void Reverse() { /*TODO*/ }

        //вставляет элемент item в список по индексу index.
        //Если такого индекса в списке нет, то генерируется исключение;
        public void Insert(int index, Type item) { /*TODO*/ }

        //удаление элемента по указанному индексу index.
        //Если такого индекса в списке нет, то генерируется исключение;
        public void RemoveAt(int index) { /*TODO*/ }

        //параметр index задает индекс, с которого надо удалить элементы,
        //а параметр count задает количество удаляемых элементов;
        public void RemoveRange(int index, int count) { /*TODO*/ }

        //возвращает список элементов,
        //количество которых равно count, начиная с индекса index;
        //public MyList<T> GetRange(int index, int count) { /*TODO*/ }
    }
}
