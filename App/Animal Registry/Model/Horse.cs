
namespace Animal_Registry.Model
{
    internal class Horse : Animal
    {
        private static int _horsesCount = 0;

        public Horse(string name, string birthday) : base(name, birthday, Type.Pack)
        {
            _horsesCount++;
        }

        public Horse()
        {
            
        }

        public static int HorsesCount
        {
            get => _horsesCount;
            set => _horsesCount = value;
        }

        public override string ToString()
        {
            return $"Лошадь: " + base.ToString();
        }
    }
}
