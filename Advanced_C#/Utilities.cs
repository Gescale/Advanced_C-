namespace Advanced_CSharp
{
    // where T : IComparable
    // where T : class
    // where T : struct
    // where T : new()
    // where T : classOfChoice (class of choice is a class you want to be used)


    // Constraints can be applied at class level as done bellow
    // The functions working with these methods are commented out below
    public class Utilities<T> // where T : IComparable
    {
        private object _value;

        // Constraints can be applied at method level as well
        public Utilities(T value)
        {
            if(value is null)
            {
                throw new ArgumentNullException("value");
            }

            _value = value;
        }

        public T GetValue()
        {
            return (T)_value;
        }

        //public static T Max(T a, T b)
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}
    }
}