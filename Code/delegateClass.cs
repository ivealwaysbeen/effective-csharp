namespace Code
{
    ///<summary>
    ///자주 사용하는 delegate를 Predicate, Func, Action으로 .NET 에서 정의해두고 있다
    ///</summary>
    public class delegateClass
    {
        public static void Start()
        {
            List<int> testList = new List<int>(){1,2,3,4,5,11,23,41,123,121};

            Predicate<int> predicateDelegate = (int a) => { return a > 10;};
            //Func<T,bool>은 Predicate<T>와 같은 기능을 한다
            Func<int,bool> funcDelegate = (int a) => {return a > 10 ? true : false; };
            Action<int> actionDelegate 
                = (int a) => { Console.WriteLine($"Action... {a.ToString()} is {(a > 10 ? "True" : "False")}"); };

            
            foreach(var test in testList)
            {
                Console.WriteLine($"Predicate... {test} is {predicateDelegate(test)}");
            }
            foreach(var test in testList)
            {
                Console.WriteLine($"Func... {test} is {funcDelegate(test)}");
            }
            foreach(var test in testList)
            {
                actionDelegate(test);
            }
        }
    }
}