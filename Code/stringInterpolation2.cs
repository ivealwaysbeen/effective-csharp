namespace Code
{
    public class stringInterpolation2
    {
        public static void Start()
        {
            //정밀한 문자열 표현
            Console.WriteLine($"pi {Math.PI:F2}");

            bool round = false;

            // : 기호가 조건 표현식으로 인식되어 컴파일 에러
            //Console.WriteLine($"pi is {round ? Math.PI.ToString() : Math.PI.ToString("F2")}");
            // {} 안에 ()를 추가해서 해결한다
            Console.WriteLine($"pi is { ( round ? Math.PI.ToString() : Math.PI.ToString("F2") ) }");

            //expression 사용
            
            string? customer = null;
            Console.WriteLine($"customer is { customer ?? "" }");

            //보간 문자열 내에 다른 보간 문자열을 포함할 수 있다.
            string customer2 = "key";
            bool check = true;
            Console.WriteLine($"customer is { (check ? $"customer info {customer2}" : "no customer info") }");

        }
    }
}