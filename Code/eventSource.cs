namespace Code
{
    ///<summary>
    ///이벤트 호출 시에는 null조건 연산자를 사용한다.
    ///</summary>
    public class eventSource
    {
        private EventHandler<int> Updated; // sender, eventargs
        private int counter;
        public void RaiseUpdater()
        {
            counter++;

            //if updated eventHandler is null, error..
            Updated(this,counter);

            //이 코드가 불릴 때 Updated가 null이 아니고
            if(Updated != null)
            //다른 스레드에서 핸들러 등록을 취소했다면, 이 코드가 불릴 때 null일 수가 있다. NullReferenceException...
                Updated(this,counter);
            
            //swallow copy
            var handler = Updated;
            //다른 스레드에 영향을 받지 않는다. 하지만 가독성에 문제... 왜 지역변수를 사용했을까...?
            if(handler != null)
                handler(this,counter);

            //null 조건 연산자와 Invoke의 사용... atomic하게 코드가 이루어진다.
            //코드도 간결하다.
            //Best code
            Updated?.Invoke(this,counter);
        }
    }
}