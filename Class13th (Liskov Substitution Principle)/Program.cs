using Program;

internal class Program
{
    static void Flying(IFlyable flyable)
    {
        flyable.Fly();
    }
    static void Main(string[] args)
    {
        #region 리스코프 치환 원칙
        // 하위 클래스는 항상 상위 클래스로 치환 가능해야 하며,
        // 이로 인해 프로그램의 동작이 변경되지 않게 설계되어야 한다는 원칙입니다.

        Dragon dragon = new Dragon();
        Slime slime = new Slime();

        dragon.Attack();
        dragon.Patrol();

        slime.Attack();
        slime.Patrol();

        Flying(dragon);
        #endregion
    }
}