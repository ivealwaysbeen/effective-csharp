namespace Code
{
    public class MySingleton
    {
        private static readonly MySingleton instance;

        static MySingleton()
        {
            instance = new MySingleton();
        }

        private MySingleton(){}

        public static MySingleton Instance
        {
            get {return instance;}
        }
    }
}