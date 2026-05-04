 internal class Program
{
    static void Main(string[] args)
    {
        #region 단일 책임 원칙
        // 클래스는 하나의 기능만 가지게 설계해야 하는 원칙입니다.

        User user = new User("coool8192@gmail.com", "FakePassword123");

        Persistence persistence = new Persistence();

        persistence.Save(user);

        Authenticate authenticate = new Authenticate(persistence);

        bool result = authenticate.Execute(user);

        if (result)
        {
            Console.WriteLine("Login Success");
        }
        else
        {
            Console.WriteLine("Login Failure");
        }

        #endregion
    }
}