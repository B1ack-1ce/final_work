
namespace Animal_Registry.Model
{
    internal class Camel : Animal
    {
        private static int _camelCount = 0;

        public Camel(string name, string birthday) : base(name, birthday, Type.Pack)
        {
            _camelCount++;
        }

        public Camel()
        {
            
        }

        public static int CamelsCount
        {
            get => _camelCount;
            set => _camelCount = value;
        }

        public override string ToString()
        {
            return $"Верблюд: " + base.ToString();
        }
    }
}
