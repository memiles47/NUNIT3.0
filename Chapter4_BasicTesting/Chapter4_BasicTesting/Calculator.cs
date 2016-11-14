namespace Chapter4_BasicTesting
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }
    }
}
