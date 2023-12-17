
namespace Animal_Registry.Model
{
    internal class Dog : Animal
    {
        private static int _dogCount = 0;

        public Dog(string name, string birthday) : base(name, birthday, Type.Home)
        {
            _dogCount++;
        }

        public Dog()
        {
            
        }

        public static int DogsCount 
        { 
            get => _dogCount; 
            set => _dogCount = value; 
        }

        public override string ToString()
        {
            return $"Собака: " + base.ToString();
        }
    }
}
