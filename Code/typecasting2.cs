namespace Code
{
    public class SecondType
    {
        private MyType myType;

        public static implicit operator MyType(SecondType t)
        {
            return t.myType;
        }
    }

    ///<summary>
    /// 사용자 정의 형변환에 대한 캐스팅 vs as
    ///</summary>
    public class typecasting2
    {
        public static void Start()
        {
            object o = new SecondType();

            /// as ///
            //as는 사용자 정의 형변환을 사용하지 않기 때문에 일관된 결과를 반환한다
            MyType myType = o as MyType;
            if(myType != null)
            {

            }
            else
            {

            }

            /// typecast ///
            try
            {
                //컴파일러는 런타임에 객체가 어떤 타입일지 예측하지 않는다(못한다)
                //오브젝트 타입에는 사용자 정의 형변환이 없으므로
                //사용자 정의 형변환을 사용하지 않는다.
                MyType myType2 = (MyType)o; 
            }
            catch(InvalidCastException)
            {

            }
        }
    }
}