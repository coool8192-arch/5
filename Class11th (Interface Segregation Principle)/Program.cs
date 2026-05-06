internal class Program
{
    static void Main(string[] args)
    {
        #region 인터페이스 분리 원칙
        // 하나의 큰 인터페이스를 여러 개의 작은 인터페이스로 나누어
        // 각 클래스가 자신에게 필요한 기능만 의존하게 설계해야 하는 원칙입니다.

        Seller seller = new Seller();
        Guide guide = new Guide();
        Sentinel sentinel = new Sentinel();

        seller.Conversation();
        seller.Sell();

        guide.Conversation();

        sentinel.Conversation();
        sentinel.TakeDamage(10);

        #endregion
    }
}