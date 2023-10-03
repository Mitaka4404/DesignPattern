namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Method();
            Singleton.Instance.Method();
            Singleton.Instance.Method();
        }
    }

    public sealed class Singleton
    {
        // private constructorを呼び出し
        // 一つのインスタンスを作成
        public static readonly Singleton Instance = new Singleton();

        // 外部のクラスが使えないように
        // priavteに設定

        private Singleton() { } 

        public void Method() 
        {
            Console.WriteLine("...");
        }
    }
}