namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 개방 폐쇄 원칙
            // 소프트웨어 개체는 확장에 대해 열려 있어야 하고, 수정에 대해 닫혀 있도록 설계되어야 한다는 원칙입니다.

            Sensor sensor = new Sensor();
            Bread bread = new Bread();
            Defective defective = new Defective();
            Sealant sealant = new Sealant();

            sensor.Detect(bread);
            sensor.Detect(defective);
            sensor.Detect(sealant);
            #endregion
        }
    }
}