using System;
using System.Collections;
using System.Collections.Generic;

namespace RingBuffer
{
    internal class RingBuffer<T>
    {
        protected readonly int _capacity;
        protected int _writeIndex;
        protected int _readIndex;
        protected int _length = 0;

        protected readonly T[] _buffer;

        public bool IsEmpty
        {
            get
            {
                return _length == 0;
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
            bool valueIsOverwritten = !IsEmpty && _writeIndex == _readIndex;
            if (valueIsOverwritten)
            {
                MoveIndexForward(ref _readIndex);
            }
            MoveIndexForward(ref _writeIndex);
            if (_length < _capacity)
            {
                _length++;
            }
        }

        public T Read()
        {
            if (IsEmpty) throw new InvalidOperationException("Buffer is empty");
            T firstInsertedElement = _buffer[_readIndex];
            _buffer[_readIndex] = default(T);
            MoveIndexForward(ref _readIndex);
            _length--;
            return firstInsertedElement;
        }

        private void MoveIndexForward(ref int index)
        {
            index = (index + 1) % _capacity;
        }

    }
}