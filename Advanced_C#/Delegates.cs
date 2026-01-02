namespace DelegateNS
{
    public delegate void MyDelagate(int a, int b);
    public class Maths
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum of integers is = " + (a + b));
        }

        public void Difference(int a, int b)
        {
            Console.WriteLine("Difference of integer is = " + (a - b));
        }
    }

    // Example usage:

    //var math = new Maths();
    //var testDelegate = new MyDelagate(math.Sum);
    //testDelegate += math.Difference;

    //testDelegate(10, 5);
}