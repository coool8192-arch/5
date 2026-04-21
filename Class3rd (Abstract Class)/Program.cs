namespace Program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 추상 클래스
            // 공통적인 기능을 제공하며, 구체적인 동작은 하위 클래스에서 정의할 수 있게 만들어진 클래스입니다.

            Barrack barrack = new Barrack();

            int select = 0;

            while (true)
            {
                Console.Write("Select soldier type : ");

                select = int.Parse(Console.ReadLine());

                if (select < 4)
                {
                    barrack.Create(select);
                }
                else if (select == 4)
                {
                    barrack.Battle();

                    Console.WriteLine("Battle is over");

                    break;
                }
            }

            #endregion
        }

    }
}
