namespace Code
{
    public class MyType
    {

    }

    ///<summary>
    /// 캐스팅보다 as 를 사용할 때 장점
    ///</summary>
    public class typecasting
    {
        public static void Start()
        {
            ///// as 사용 /////
            object o = new MyType();
            MyType myType = o as MyType;

            if(myType != null)
            {
                //MyType 객체 사용
            }
            else
            {
                //오류 보고
            }


            ///// 캐스팅 사용 /////
            object o2 = new MyType();
            //try-catch문 사용으로 성능 저하, 가독성 저하
            try
            {
                MyType myType1 = (MyType)o2;

                //as문 처럼 널 체크도 해줘야한다
                if(myType1 != null)
                {
                    //MyType 객체 사용
                }
                else
                {
                    //오류 보고
                }
                
            }
            catch(InvalidCastException)
            {
                //오류 보고
            }
            
        }
    }
}