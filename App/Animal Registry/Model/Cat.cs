
namespace Animal_Registry.Model
{
    internal class Cat : Animal
    {
        private static int _catCount = 0;

        public Cat(string name, string birthday) : base(name, birthday, Type.Home)
        {
            _catCount++;
        }

        public Cat()
        {
            
        }

        public static int CatsCount 
        { 
            get => _catCount;
            set => _catCount = value;
        }

        public override string ToString()
        {
            return $"Кот: " + base.ToString();
        }
    }
}
