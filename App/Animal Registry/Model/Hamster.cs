
namespace Animal_Registry.Model
{
    internal class Hamster : Animal
    {
        private static int _hamsterCount = 0;

        public Hamster(string name, string birthday) : base(name, birthday, Type.Home)
        {
            _hamsterCount++;
        }

        public Hamster()
        {
            
        }

        public static int HamstersCount 
        { 
            get => _hamsterCount; 
            set => _hamsterCount = value; 
        }

        public override string ToString()
        {
            return $"Хомяк: " + base.ToString();
        }
    }
}
