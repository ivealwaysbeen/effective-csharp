namespace Code
{
    public class VarClass
    {
        public static double GetMagicNumber()
        {
            var random = new Random();
            return random.NextDouble();
        }
        public static int GetRandomInt()
        {
            var random = new Random();
            return random.Next(1,10);
        }

        public static int GetRandom()
        {
            var random = new Random();
            return random.Next(1,10);
        }

        public static void Start()
        {
#region var 시용법
            var random = GetRandom(); // 메서드 이름으로 변수의 타입을 유추하기 힘들다.
            var a = 10; // 모호한 변수의 이름을 사용하면 안된다.

            var randomNumber = GetRandomInt(); // 옳은 var 사용법
#endregion

            var magicNumber = GetMagicNumber();

            //total의 타입은 magicNumber의 타입에 의하여 정의된다.
            //var total = 100 * magicNumber / 7;

            //이럴 때는 원하는 타입을 명시적으로 선언해주는 것이 좋다
            double doubleValue = 100 * magicNumber / 7;

            Console.WriteLine($"Declared Type : {doubleValue.GetType().Name}, Value: {doubleValue}");
        }
    }
}