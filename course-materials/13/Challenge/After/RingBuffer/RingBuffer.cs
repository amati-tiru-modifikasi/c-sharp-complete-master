using System;

namespace RingBuffer
{
    internal class RingBuffer<T>
    {
        protected readonly int _capacity;
        protected int _writeIndex;
        protected int _readIndex;
        protected int _numberOfElements = 0;

        protected readonly T[] _buffer;

        public bool IsEmpty
        {
            get
            {
                return _numberOfElements == 0;
            }
        }
        public RingBuffer(int capacity)
        {
            _capacity = capacity;
            int startIndex = new Random().Next(0, _capacity);
            _writeIndex = startIndex;
            _readIndex = startIndex;
            _buffer = new T[capacity];
        }

        public void Write(T value)
        {
            _buffer[_writeIndex] = value;
            bool oldestValueIsOverwritten = !IsEmpty && _writeIndex == _readIndex;
            if (oldestValueIsOverwritten)
            {
                MoveIndexForward(ref _readIndex);
            }
            MoveIndexForward(ref _writeIndex);
            if (_numberOfElements < _capacity)
            {
                _numberOfElements++;
            }
        }

        public T Read()
        {
            if (IsEmpty) throw new InvalidOperationException("Buffer is empty");
            T firstInsertedElement = _buffer[_readIndex];
            _buffer[_readIndex] = default(T);
            MoveIndexForward(ref _readIndex);
            _numberOfElements--;
            return firstInsertedElement;
        }

        private void MoveIndexForward(ref int index)
        {
            index = (index + 1) % _capacity;
        }

    }
}