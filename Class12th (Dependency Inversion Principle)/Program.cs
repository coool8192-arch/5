internal class Program
    {
        static void Main(string[] args)
        {
            #region 의존 역전 원칙
            // 추상화는 세부 사항에 의존해서는 안 되고, 세부 사항은 추상화에 의존해야 한다는 원칙입니다.

            Knife knife = new Knife();
            Rifle rifle = new Rifle();
            Character character = new Character();

            character.Acquire(knife);
            character.Acquire(rifle);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.Spacebar)
                    {
                        character.Swap();
                    }

                    if (key == ConsoleKey.A)
                    {
                        character.Use();
                    }
                }
            }
            #endregion
        }
    }