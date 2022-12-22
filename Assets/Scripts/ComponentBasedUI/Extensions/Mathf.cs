namespace ComponentBasedUI.Extensions
{
    public static class Mathf
    {
        public static int ClampInt01(int value)
        {
            if (value > 1)
            {
                return 1;
            }
            
            if(value < 0)
            {
                return 0;
            }

            return value;
        }

        public static int InverseRaw01(int value)
        {
            return Inverse01(ClampInt01(value));
        }

        public static int Inverse01(int value)
        {
            return value == 0 ? 1 : 0;
        }
    }
}
