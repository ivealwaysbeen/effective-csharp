namespace Code
{
    ///<summary>
    ///delegate는 멀티캐스트가 가능하다.
    ///멀티캐스트 델리게이트는 객체에 추가된 모든 함수들을 호출한다.
    ///반환값은 마지막에 호출된 함수의 반환값이다.
    ///</summary>
    public class delegateMulticast
    {
        public static void Start()
        {
            //multicast delegate
            Func<bool> cp = () => {return true;};
            cp += () => {return false;};
            cp += () => {return true;};
            cp += () => {return false;};

            int count = 0;
            while(count < 10)
            {
                count++;
                //항상 마지막 메서드 반환값만 출력
                Console.WriteLine(cp());
            }

            count = 0;
            while(count < 10)
            {
                count++;
                //델리게이트에 추가된 메서드 리스트를 사용하면 추가된 모든 메서드의 반환값을 사용할 수 있다.
                foreach(Func<bool> func in cp.GetInvocationList())
                {
                    Console.WriteLine(func());
                }
            }
            
        }
    }
}