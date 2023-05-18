namespace Events
{
    internal class Program
    {
        delegate void Bob();
        public static double x; public static double y;
        class Events
        {
            Bob[] eve =new Bob[4];
            public event Bob SomeEvent
            {
                add
                {
                    int i;
                    for ( i = 0; i < 4; i++)
                    {
                        if (eve[i] == null)
                        {
                            eve[i] = value; break;
                        }
                    }
                    if (i == 3) { Console.WriteLine("Список заполен"); }
                }
                remove
                {
                    int i;
                    for ( i = 0;i < 4; i++)
                    {
                        if (eve[i] == value)
                        {
                            eve[i]=null
                                ; break;
                        }
                    }
                    if (i == 3) { Console.WriteLine("Не найдено"); }
                }
            }
            public void Activate()
            {
                for (int i = 0;i<4 ; i++) 
                {
                    if (eve[i] != null) { eve[i](); }
                }
            }
        }
        public static void Summ()
        {
            Console.WriteLine(x+y);
        }
        public static void Minus()
        {
            Console.WriteLine(x - y);
        }
        public static void Mult()
        {
            Console.WriteLine(x * y);
        }
        public static void Divide()
        {
            try{ Console.WriteLine(x / y); }
            catch { Console.WriteLine("Ошибка деления"); }
        }
        static void Main(string[] args)
        {
            Events myevent=new Events(); 
            x=Convert.ToDouble(Console.ReadLine());
            y=Convert.ToDouble(Console.ReadLine());
            
            myevent.SomeEvent += Summ;
            myevent.SomeEvent += Minus;
            myevent.SomeEvent += Mult;
            myevent.SomeEvent += Divide;

            myevent.Activate();
        }
    }
}