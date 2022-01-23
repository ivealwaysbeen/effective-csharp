namespace Code
{
    ///<summary>
    ///박싱이란 값타입 객체를 정해져 있지 않은 임의의 참조 타입 내부에 포함시키는 것
    ///언박싱이란 참조 타입의 객체로 부터 값 타입의 객체의 복사본을 가져오는 것
    ///박싱과 언박싱은 피할 수 있다면 최소화하라
    ///성능에 문제(매모리, 퍼포먼스)를 발생시키고, 에러코드를 만들 확률이 높다
    ///</summary>
    public class boxingUnboxing
    {
        struct Person
        {
            public string Name;
        }
        public static void Start()
        {
            int i = 10;

            //boxing!
            object o = i;
            o = 12;
            //unboxing!
            int j = (int)o;
            o = 11;
            Console.WriteLine($"i is {i} j is {j}");
            //i is 10 j is 11

//////////////////////////////////////////////////////////////////

            //.NET 1.x Collection
            var attendees = new List<Person>();
            Person p = new Person {Name = "Old"};
            //value type to object (boxing) and save...
            attendees.Add(p);

            //object type to value type (unboxing)
            Person p2 = attendees[0];
            //p1 != p2
            p2.Name = "New";

            //Old
            Console.WriteLine(attendees[0].Name);
        }
    }
}