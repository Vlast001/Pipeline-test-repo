public class Calculator
{
    private static Calculator? instance;
    private Calculator(){}

    public static Calculator GetCalculator()
    {
        if (instance == null)
            instance = new Calculator();
        return instance;
    }

    public T Add<T>(T a, T b)
    {
        if (a == null || b == null)
        {
            throw new ArgumentNullException("Agruments cannot be null.");
        }

        if (IsNumericType<T>())
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA + dynamicB;
        }
        else
        {
            throw new ArgumentException("Both arguments should be numeric.");
        }
    }

    private bool IsNumericType<T>()
    {
        return typeof(T) == typeof(int) ||
               typeof(T) == typeof(float) ||
               typeof(T) == typeof(double) ||
               typeof(T) == typeof(decimal) ||
               typeof(T) == typeof(byte) ||
               typeof(T) == typeof(short) ||
               typeof(T) == typeof(long) ||
               typeof(T) == typeof(uint) ||
               typeof(T) == typeof(ushort) ||
               typeof(T) == typeof(ulong) ||
               typeof(T) == typeof(sbyte);
    }
}