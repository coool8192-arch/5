namespace Program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 컬렉션
            // 데이터를 저장, 추가, 삭제 그리고 순회하는 기능을 포함한 데이터 관리 구조입니다.

            #region List

            //List<int> list = new List<int>();
            //
            //list.Capacity = 10;
            //
            //
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add(40);
            //list.Add(50);
            //
            //list.Remove(50); // 특정 값을 찾아 제거함
            //
            //list.RemoveAt(list.Count - 1); // 특정 인덱스의 값을 제거함
            //
            //list.Insert(1, 15);
            //
            //if (list.Contains(25)) // 해당하는 데이터가 있는지 확인함
            //{
            //    Console.WriteLine("Data found");
            //}
            //else
            //{
            //    Console.WriteLine("Data not found");
            //}
            //
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //
            //Console.WriteLine("List capacity : " + list.Capacity);

            #endregion

            #region Queue

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            if(queue.Contains(15))
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not found");
            }

            for (int i = queue.Count; i > 0; i--)
            {
                Console.WriteLine(queue.Peek());

                queue.Dequeue();
            }
            #endregion

            #region 스택

            //Stack<int> stack = new Stack<int>();
            //
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);
            //
            //for (int i = stack.Count; i > 0; i--) 
            //{
            //    Console.WriteLine(stack.Peek());
            //
            //    stack.Pop();
            //}

            #endregion

            #endregion
        }

    }
}
