namespace Program
{
    internal class Program
    {
        delegate float Operation(float x, float y);

        static float Add(float x, float y)
        {
            return x + y;
        }

        static float Substract(float x, float y)
        {
            return x - y;
        }

        static float Multiply(float x, float y)
        {
            return x * y;
        }

        static float Devide(float x, float y)
        {
            return x / y;
        }

        void Execute(Operation operation)
        {

        }

        static void Main(string[] args)
        {
            #region 대리자
            // 특정 함수를 가진 함수를 참조할 수 있는 참조 타입입니다.

            Operation operation;

            operation = Add;

            Console.WriteLine(operation(2.5f, 1.25f));

            operation = Substract;

            Console.WriteLine(operation(2.5f, 1.25f));

            operation = Multiply;

            Console.WriteLine(operation(2.5f, 1.25f));

            operation = Devide;

            Console.WriteLine(operation(2.5f, 1.25f));

            #endregion
        }
    }
}