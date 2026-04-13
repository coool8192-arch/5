namespace Program
{
    internal class Program
    {
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

        }

    }
}
