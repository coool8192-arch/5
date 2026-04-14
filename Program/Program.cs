namespace Program
{
    public class Circle
    {
        public Circle()
        {
            Console.WriteLine("Circle created");
        }

       public int x;
       public int y;
       public float radius;
    }

    internal class Program
    {
        static void Collide(Circle c1, Circle c2)
        {
            float Radius = (c1.radius + c2.radius) * (c1.radius + c2.radius);
            float Distance = ((c1.x - c2.x) * (c1.x - c2.x) + (c1.y - c2.y) * (c1.y - c2.y));

            if (Radius < Distance)
            {
                Console.WriteLine("Do not collide");
            }
            else
            {
                Console.WriteLine("Collided");
            }
        }

        static void Main(string[] args)
        {
            #region 매개 변수 한정자
            // 인수가 함수에 전달되는 방식과 사용 규칙을 제어하는 한정자입니다.

            Circle circle1 = new();
            Circle circle2 = new();

            circle1.x = 2;
            circle1.y = 3;
            circle1.radius = 4.5f;

            circle2.x = 5;
            circle2.y = 1;
            circle2.radius = 2.75f;

            Collide(circle1, circle2);

            #endregion
        }

    }
}
