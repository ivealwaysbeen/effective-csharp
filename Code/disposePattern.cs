using System;

namespace Code
{
    public class ResourceHub : IDisposable
    {
        private bool alreadyDisposed = false;

        public void Dispose()
        {
            //가상 dispose 호출
            Dispose(false);

            //Finalize 회피
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            //이미 dispose가 호출되었다면 리턴
            if(alreadyDisposed == true)
                return;

            if(isDisposing == true)
            {
                //관리되는 리소스 정리
            }

            //비관리 리소스 정리

            //dispose 호출 플래그
            alreadyDisposed = true;
        }

    }

    public class disposePattern : ResourceHub
    {
        private bool alreadyDisposed = false;

        protected override void Dispose(bool isDisposing)
        {
             if(alreadyDisposed == true)
                return;

            if(isDisposing == true)
            {
                //관리되는 리소스 정리
            }

            //비관리 리소스 정리

            //베이스 클래스가 자신의 리소스를 정리할 수 있도록 해준다.
            //베이스 클래스에서는 무조건 finalize 회피 코드가 있어야한다.
            base.Dispose(isDisposing);

            //dispose 호출 플래그
            //모든 클래스에서 dispose가 되었는지를 확인하기 위해서 존재한다
            alreadyDisposed = true;
        }

        //Finalizer는 비관리 리소스를 포함하고 있을 때 필수적으로 구현해줘야 한다.
        //반대로 비관리 리소스가 없다면 성능저하를 일으키는 원인이므로 구현하지 않는다.
        /*
        ~disposePattern()
        {
            
        }
        */
    }

    public class badclass
    {
        private static readonly List<badclass> finalizedList = new List<badclass>();
        private string msg;

        public badclass(string msg)
        {
            this.msg = msg;
        }

        ~badclass()
        {
            //finalize가 호출되면서 객체를 다시 도달 가능한 객체로 만들어준다.
            //더이상 finalize가 호출되지 않는 객체가 된다.
            //멤버 변수 또한 가비지로 간주되었으므로 언젠가 정리되어 사용할 수 없다.
            finalizedList.Add(this);
        }
    }

    //
    
}