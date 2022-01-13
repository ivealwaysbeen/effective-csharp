namespace Code
{
    ///<summary>
    ///string.Format() 대신 문자열 보간 기능을 사용하여야 하는 이유
    ///</summary>
    public class stringInterpolation
    {
        public static void Start()
        {
            int number = 10;
            float float_number = 10.9f;
            
            //기존에 사용하던 string.format()
            //인자의 개수가 불일치 할 수 있다. 런타임 오류 발생.
            Console.WriteLine("use string format {0}",number,float_number);//runtime error

            //6.0 부터 사용가능한 string interpolation
            //가독성이 뛰어나고, 실수를 할 일이 없다.
            Console.WriteLine($"use string interpolation {number}");

            //문자열 보간 기능을 사용하더라도 실제 컴파일러는 기존 포매팅 함수를 호출하므로 인자를 object로 바꾼다.
            //number은 값 타입이므로 박싱
            //박싱이 일어나기 전에 미리 문자열로 변경한다
            Console.WriteLine($"use string interpolation remove boxing... {number.ToString()}");
            

        }
    }
}