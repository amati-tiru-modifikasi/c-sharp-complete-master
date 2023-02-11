using System;

namespace RingBuffer
{
    internal class RingBuffer<T>
    {
        // here you must create the fields
        // _capacity (can be modified in the ctor and at declaration only)
        // _writeIndex
        // _readIndex
        // _numberOfElements

        // here you must an array of type T

        // here you must create the IsEmpty property

        // here you must create the constructor (one parameter : the buffer capacity)
        // _writeIndex and _readIndex must be inititalized to the same random value

        public void Write(T value)
        {
            // here you must implement the Write method
            throw new NotImplementedException();
        }

        public T Read()
        {
            // here you must implement the Read method
            throw new NotImplementedException();
        }
    }
}