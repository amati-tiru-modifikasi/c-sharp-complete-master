namespace Conversions
{
    class WeightConverter
    {
        private const float ACCELERATION = 9.8f;

        public static float Convert(float mass)
        {
            return mass * ACCELERATION;
        }
    }
}  