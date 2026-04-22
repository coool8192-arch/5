using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 인터페이스
            // 객체가 외부에 제공할 기능을 정의하고, 구현은 포함하지 않는 참조 타입입니다.


            ISelectable[] selectable = { new Frame(), new Clock(), new Switch() };

            int select = 0;

            while (true)
            {
                Console.WriteLine("0 : Frame | 1 : Clock | 2 : Switch");

                Console.Write("Select what you want to check : ");

                if (int.TryParse(Console.ReadLine(), out select) == false)
                {
                    Console.WriteLine("Invalid input!");

                    continue;
                }

                if (select < selectable.Length && select >= 0)
                {
                    selectable[select].select();

                    if (selectable[select] is IActivatable activatable)
                    {
                        if (activatable != null)
                        {
                            Console.WriteLine("Do you want to check this item?\n");

                            Console.WriteLine("0 : Yes | 1 : No");

                            if (int.TryParse(Console.ReadLine(), out select) == false)
                            {
                                Console.WriteLine("Invalid input!");

                                continue;
                            }

                            if (select >= 0 && select < 1) activatable.activate();
                            else continue;
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Exception");
                }
            }
            #endregion
        }

    }
}
