namespace SanPellgrino
{
    public static class BoolExtensions
    {
        public static bool IsFalse(this bool value)
        {
            return !value;
        }

        public static bool IsTrue(this bool value)
        {
            return value;
        }
    }
}