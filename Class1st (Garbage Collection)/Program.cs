
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
        #region 박싱
        // 값 타입을 참조 타입으로 변환하여 관리되는 힙 영역에
        // 새로운 객체를 만들고 복사하는 과정입니다.

        //int count = 0;
        //
        //object clone;
        //
        //clone = count;
        //
        //Console.WriteLine("clone = " + clone);
        //Console.WriteLine("count = " + count);

        #endregion

        #region 언박싱
        // 관리되는 힙에 있는 박싱된 개체에서
        // 값을 꺼내 값 타입으로 복사하는 과정입니다.

        //long exp = 150;
        //
        //object address = exp;
        //
        //long data = (long)address;
        //
        //Console.WriteLine("data = " + data);
        //Console.WriteLine("address = " + address);
        //Console.WriteLine("exp = " + exp);

        #endregion

        #region 가비지 컬렉터
        // 메모리 관리를 담당하는 시스템으로, 메모리에서 더 이상 사용되지 않는
        // 객체를 탐색하여 메모리를 회수하는 기법입니다.

        // Mark : Root Space로부터 그래프 순회를 통해 연결된 객체들을 찾아 각각 어느 객체를 참조하고 있는지 찾습니다.

        // Sweep : 참조하고 있지 않은 객체(Unreachable 객체)를 관리되는 힙 영역에서 제거합니다.

        // Compact : Sweep 후에 분산된 객체들을 관리되는 힙 영역의 시작 주소로 모아
        //           메모리가 할당된 부분과 그렇지 않은 부분을 압축합니다.

       //Circle circle1 = new();
       //Circle circle2 = new();
       //
       //circle1.x = 2;
       //circle1.y = 3;
       //circle1.radius = 4.5f;
       //
       //circle2.x = 5;
       //circle2.y = 1;
       //circle2.radius = 2.75f;
       //
       //Collide(circle1, circle2);


        #endregion
    }

}