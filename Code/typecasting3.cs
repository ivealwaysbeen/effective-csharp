namespace Code
{
    ///<summary>
    /// as를 사용할 수 없는 경우
    ///</summary>
    public class typecasting3
    {
        public class Factory
        {
            public static int GetValue()
            {
                return 3;
            }
        }
        public static void Start()
        {
            object o = Factory.GetValue();

            //i는 어떠한 정수 값이 들어가야 하고
            //o는 null일 수 있기 때문에 컴파일 에러.
            //int i = o as int;

            // nullable 타입으로 형변환한다
            var i = o as int ?;
            if(i != null)
                Console.WriteLine(i.Value);


            

        }
    }
}