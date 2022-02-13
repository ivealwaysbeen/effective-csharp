# effective-csharp

## 개요
Effecitve C# 책에서 나오는 내용을 직접 구현해보고 공유하는 공간입니다

-----------------------------

## C# 언어요소
1. 지역변수를 선언할 때는 var를 사용하는 것이 낫다
> * 리턴 타입에 대한 정확한 반환 타입을 얻을 수 있다.
> * var를 사용할 때는 변수명 또는 리턴하는 메소드명에서 타입을 유추할 수 있도록 한다.
> * 내장된 형변환을 사용할 경우, 반환 타입을 유추하기 힘들다.


2. const보다는 readonly가 좋다
> * C#은 컴파일타임 상수 const와 런타임 상수 readonly 두 유형의 상수를 가진다.
> * const는 더 빠르긴 하지만 readonly에 비해 유연성이 떨어진다.
>   + const는 메서드 내부에서 선언할 수 없다. readonly는 가능하다(인스턴스마다 다른 상수값을 가질 수 있게 된다)
>   + const는 내장 자료형만 선언 가능하다.
> * const는 컴파일 타임에 값으로 대체되고, readonly는 컴파일 타임에 상수에 대한 참조로 컴파일된다.


3. 캐스트보다는 is, as가 좋다 
> * 캐스트를 사용할 경우, try-catch 문을 사용해야할 뿐만 아니라, 널 체크까지 해줘야 한다. 반면에 as는 널 체크만 해주면 된다.
> * 더 방어적인 코드를 작성하기 위해서는 is 연산자를 먼저 사용해본다.
> * as나 is 연산자는 사용자 정의 형변환을 사용할 수 없다. 때문에 항상 동일한 결과를 반환한다.
> * 캐스팅을 사용하면 사용자 정의 형변환을 사용할 수 있지만, 컴파일 타임에 객체의 타입을 기준으로 추적하기 때문에 원하는 결과를 얻기 힘들다.(코드도 흉해진다)

4. string.Format()을 보간 문자열로 대체하라
> * expression이라고 하기에는 if/else while가 같은 제어 흐름을 변경할 수 없다.
> * 보간 문자열을 사용하면 인자를 누락하는 실수를 줄일 수 있다.
> * 박싱을 막기 위해서는 toString()을 사용하여 미리 변환한다.
> * 보간 문자열 안에 다른 보간 문자열을 포함시킬 수 있다.

5. 문화권별로 다른 문자열을 생성하려면 FormattableString을 사용하라
> * FormattableString 타입의 객체를 활용하면 문화권과 언어를 지정하여 문자열을 생성할 수 있다.

6. nameof() 연산자를 적극 활용하라
> * 심볼 그 자체를 해당 심볼을 포함하는 문자열로 대체해준다.
> * 심볼의 이름을 평가하며, 타입, 변수, 인터페잇스, 네임스페이스에 대하여 사용할 수 있다.
> * 제네릭 타입을 사용할 경우에는 모든 타입 매개변수를 지정한 닫힌 제네릭 타입만 사용할 수 있다.
> * 정규화된 이름(System.Int.MaxValue)을 사용하더라도 항상 로컬 이름(MaxValue)을 반환한다.
> * 문자열을 하드코딩 하는 대신 nameof()를 사용하면 이름 바꾸기 작업을 수행할 때도 실수를 줄일 수 있다.

7. 델리게이트를 이용해 콜백을 표현해라
> * .NET 프레임워크 라이브러리는 Predicate<T>, Action<>, Func<>와 같은 형태로 자주 사용되는 델리게이트를 정의해두고 있다.
> * 역사적인 이유로 모든 델리게이트는 멀티캐스트가 가능하다. 그리고 마지막으로 호출된 대상 함수의 반환 값이 델리게이트의 반환값으로 간주된다.
> * 멀티캐스트 델리게이트는 순차적으로 함수를 호출하고, 어떠한 예외도 잡지 않으며 예외가 발생할 경우 호출 과정이 중단된다.

8. 이벤트 호출 시에는 null 조건 연산자를 사용하라
> * 이벤트 핸들러가 결합되어 있는지를 확인하는 코드와, 이벤트를 발생시키는 코드 사이에 경쟁 조건이 발생할 경우 문제가 될 수 있다.
> * C# 6.0에서 추가된 null 조건 연산자를 활용하면 두 가지 코드가 원자적으로 실행됨으로 문제를 예방할 수 있다.
  
9. 박싱과 언박싱의 최소화하라
> * 값 타입은 주로 값을 저장할 때 쓰는 저장소이며 다형적이지 못하다.
> * .NET Framwork는 모든 타입의 최상위 타입을 참조 타입인 System.Object로 정의한다.
> * 박싱은 값타입을 참조 타입으로, 언박싱은 참조타입을 값타입으로 이어주는 과정이고 성능에 좋지 않은 영향을 끼치고, 버그도 많이 발생시킨다.
> * 박싱 : 값 타입을 참조 타입으로 변경할 때 새롭게 생성된 참조 타입 객체는 힙에 생성되고, 값 타입이 복사본이 객체 내부에 저장된다.
> * 언박싱 : 힙에 있던 객체를 값 타입으로 형변환하고 스택에 저장된다.
  
10. 베이스 클래스가 업그레이드된 경우에만 new 한정자를 사용하라
> * 베이스 클래스에서 virtual로 선언하지 않은 멤버를 재정의하려는 경우 new 한정자를 사용한다.
> * new 한정자를 사용할 경우 두 메서드는 다른 작업을 수행하므로 혼돈을 줄 수 있다.

## .NET 리소스 관리 (가비지 콜렉터 & 비관리 리소스 관리)
11. .NET 리소스 관리에 대한 이해
> * .NET 환경에서는 특별히 메모리 관리와 가비지 수집기의 동작 방식을 정확히 이해하는 것이 중요하다.
> * 가비지 수집기는 관리되는 메모리(managed memory)를 관장하며 네이티브 환경과는 다르게 메모리 누수, 댕글링 포인터, 초기화되지 않는 포인터, 여타의 메모리 관리 문제를 자동화해준다. 그럼에도 개발자가 더 신경쓴다면 효과적으로 가비지 수집기를 사용할 수 있다.
> * DB객체, GDI+ 객체, COM 객체, 시스템 객체 등과 같은 비관리 리소스는 여전히 개발자가 직접 관리해야 한다. 이벤트 해들러, 델리게이트, 쿼리 등도 잘못 사용할 경우 오랫동안 메모리를 점유할 수 있다.
> * 가비지 수집기는 Mark/Compact 알고리즘(여러 객체 사이의 연관 관계를 파악, 사용되지 않는 객체를 제거)을 사용하여 리소스를 관리한다.
> * 콤팩트 작업이란 사용 중인(도달 가능한) 객체들을 한쪽으로 옮기고 조각난 메모리들을 큰 메모리 공간으로 만드는 과정이다.
> * .NET Framwork에서는 비관리 리소스의 생명주기를 Finalizer와 IDisposable 인터페이스 두 가지 매커니즘으로 관리한다.
> * ### finalizer
>> * finalizer는 비관리 리소스에 대한 해제 작업이 반드시 수행될 수 있도록 도와주는 방어적인 매커니즘이지만, 단점이 많다. (IDisposalbe의 사용을 권장한다.)
>> * finailizer를 가지고 있는 객체는 가비지로 판단될 경우, 바로 매모리를 해제하지 않고(finalizer를 호출해야 하지 때문이다), 이 객체를 다른 큐에 삽입한 후에, 나중에 finalizer가 호출될 수 있도록 준비만 한다.
>> * 일정 시간이 경과한 이후 다시 한번 가비지 수집 절차가 수행되면, 앞서 큐에 삽입된 객체를 참조하여, 해당 객체가 가지고 있는 finalizer를 순서대로 호출 한다.
> * ### Generation
>> * .NET 가비지 수집기는 수집 과정을 최적화 하기 위해 세대라는 개념을 사용한다.
>> * 0세대 객체 : 마지막 가비지 수집기가 수행된 이후 생성된 객체
>> * 1세대 객체 : 0세대 객체 중에 가비지 수행 과정 이후 살아 남은(도달 가능한) 객체
>> * 2세대 객체 : 1세대 객체 중에 가비지 수행 과정 이후 살아 남은(도달 가능한) 객체 (2번 이상 살아남은 객체)
>> * 멤버 변수(전역 변수)는 세대가 높아질 확률이 높다.
>> * 1세대 객체에 대한 가비지 수집은 10번에 한 번 꼴로 수행되며, 2세대 객체에 대한 수집은 100번에 한 번 꼴로 수행된다.
>> * finailzer를 포함한 객체는 즉각적으로 해제되지 않으므로 1또는 2세대 객체가 되므로 성능에 약영향을 끼칠 수 있다. IDisposalbe 인터페이스로 수집 과정이 지연되는 것을 방지할 수 있다.


