namespace Comments
{
    /// <summary>
    /// Provides static methods for performing arithmetical operations
    /// on single-precision floating point numbers
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Returns the result of the multiplication of two single-precision
        /// floating point numbers
        /// </summary>
        /// <param name="x">The first single-precision floating point number to multiply</param>
        /// <param name="y">The second single-precision floating point number multiply</param>
        /// <returns>The single-precisoin floating point number result of the multiplication</returns>
        public static float Multiply(float x, float y)
        {
            return x * y;
        }

        /// <summary>
        /// Returns the result of the division of two single-precision
        /// floating point numbers
        /// </summary>
        /// <param name="x">The first single-precision floating point number to divide</param>
        /// <param name="y">The second single-precision floating point number to divide</param>
        /// <returns>The single-precisoin floating point number result of the division</returns>
        public static float Divide(float x, float y)
        {
            return x / y;
        }
    }
}