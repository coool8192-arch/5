    internal class Program
{

    static void Main(string[] args)
    {
        #region 열거자
        // 다수의 항목으로 구성된 데이터 집합에서 각 요소를
        // 하나씩 순서대로 꺼내 사용할 수 있게 해주는 객체입니다.

        Inventory<Item> inventory = new Inventory<Item>();

        Item knife = new();

        knife.Name = "Knife";
        knife.Level = 1;
        knife.explanation = "Normal knife for meal.";

        inventory.Add(knife);
        inventory.Add(knife);
        inventory.Add(knife);
        inventory.Add(knife);
        inventory.Add(knife);

        foreach (Item item in inventory)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Level);
            Console.WriteLine(item.explanation);
        }
        #endregion
    }
}