using System.Linq;
using System.Text;

namespace RingBuffer
{
    internal class IntegerRingBuffer : RingBuffer<int?>
    {
        public IntegerRingBuffer(int _capacity) : base(_capacity)
        {

        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"Buffer : || ");

            var max = _buffer.Max();

            for (int i = 0; i < _buffer.Length; i++)
            {
                int placeHolderLength = max != null ? max.ToString().Length : 1;
                string leftPadding = string.Empty.PadLeft(placeHolderLength - _buffer[i].ToString().Length);
                string message = _buffer[i] != null ?
                    $"{leftPadding + _buffer[i].Value.ToString()}" :
                    new string('*', placeHolderLength);
                builder.Append($"{message} || ");
            }
            return builder.ToString();
        }
    }
}