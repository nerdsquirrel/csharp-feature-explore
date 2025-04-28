namespace CSharpFeatureExplore.Event_Delegate
{
    internal class DelegateMultipleWay
    {
        private delegate int MultiplyDelegate(int number1, int number2);

        public static void Show()
        {
            // TODO: 1. Assign using a normal method
            MultiplyDelegate multiplyDelegate = MultiplyTwoNumber;


            // TODO: 2. Assign using an anonymous method
            multiplyDelegate = delegate (int number1, int number2)
            {
                return number1 * number2;
            };

            // TODO: 3. Assign using a lambda expression
            multiplyDelegate = (number1, number2) => number1 * number2;


            Console.ReadLine();
        }

        static int MultiplyTwoNumber(int number1, int number2)
        {
            return number1 * number2; ;
        }
    }
}
