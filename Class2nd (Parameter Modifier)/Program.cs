public class Puzzle
{
    public string word;

    public void Decrease(ref int life)
    {
        life--;
    }

    public void Render()
    {
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(word[i] + " ");
        }
    }

    public void Render(in int index)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (i == index)
            {
                Console.Write("_ ");
            }
            else
            {
                Console.Write(word[i] + " ");
            }
        }
    }

    public void Initialize(params string[] list)
    {
        Random r = new Random();

        word = list[r.Next(0, list.Length)];
    }

    public void Validate(char input, int index, out bool state)
    {
        if (word[index] == input)
        {
            state = true;
        }
        else
        {
            state = false;
        }
    }

}


internal class Program
    {
        static void Main(string[] args)
        {

        #region 매개 변수 한정자
        // 인수가 함수에 전달되는 방식과 사용 규칙을 제어하는 한정자입니다.

        int life = 5;

        Puzzle puzzle = new Puzzle();

        Random random = new Random();

        puzzle.Initialize("apple", "banana", "cherry");

        bool state = false;

        int index = random.Next(0, puzzle.word.Length);

        puzzle.Render(index);

        while (true)
        {
            Console.WriteLine();

            Console.WriteLine("current life : " + life);

            char answer = Console.ReadKey().KeyChar;

            Console.WriteLine();

            puzzle.Validate(answer, index, out state);

            if (state == true)
            {
                Console.WriteLine(" VICTORY!");

                break;

            }
            else
            {
                Console.WriteLine("wrong");

                puzzle.Decrease(ref life);
            }

            if (life <= 0)
            {
                Console.WriteLine("DEFEAT...");

                break;
            }
        }


        #endregion
    }
}

