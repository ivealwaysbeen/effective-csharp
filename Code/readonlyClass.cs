namespace Code
{
    public class readonlyClass
    {
        public class DummyClass
        {
            public DummyClass()
            {

            }
        }
        //컴파일타임 상수
        public const int const_number = 100;
        //내장 자료형이 아니므로 에러
        public const DummyClass dummy = new DummyClass(); //error


        //런타임 상수
        public static readonly int readonly_number = 100;
        //컴파일 타임 상수가 아니므로 ok
        public readonly DummyClass readonly_dummy = new DummyClass();
        public readonly int readonly_number_ctor;

        public readonlyClass()
        {
            //런타임 상수는 생성자에서 초기화 될 수 있다.
            readonly_number_ctor = 10;
        }

        public readonlyClass(int readonly_number)
        {
            //런타임 상수는 생성자에서 초기화 될 경우 다른 값을 가질 수 있다.
            readonly_number_ctor = readonly_number;
        }
        public static void Start()
        {
            int a = 100;


            if(a == const_number) //컴파일타임에 if(a == 100) 과 같다
            {

            }

            if(a == readonly_number)//컴파일타임에 상수에 대한 참조로 컴파일 된다.
            {

            } 

        }

        


    }
}