namespace Code
{
    public class newkeyword : baseClass
    {
        ///<summary>
        ///new 한정자는 이미 널리 사용되는 메서드를 일일히 찾아서 수정하기 어렵거나 외부 어셈블리에서 이 메서드를 사용하여 수정할 수 없는 경우에 사용한다.
        ///하지만 근본적으로 기존에 사용하던 메서드에 접근이 가능하다면 같은 이름의 함수가 다른 기능을 하는 것은 막을 수 없다.
        ///</summary>
        public new void Foo()
        {

        }

        public override void Goo()
        {
            
        }
        public static void Start()
        {

        }
    }

    public class baseClass
    {
        public void Foo()
        {

        }
        ///<summary>
        ///가상함수로 선언한다는 것은 다형성이 필요로하다는 것을 뜻한다. 구현부를 변경할 것을 예상하고 있으며, 파생클래스에서의 변경에도 문제없이 작동해야 한다.
        ///가상 메서드를 신중하게 사용해야 사용자에게 더 정확한 가이드라인을 제공할 수 있다.
        ///</summary>
        public virtual void Goo()
        {

        }
    }
}