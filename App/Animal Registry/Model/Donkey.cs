
namespace Animal_Registry.Model
{
    internal class Donkey : Animal
    {
        private static int _donkeyCount = 0;

        public Donkey(string name, string birthday) : base(name, birthday, Type.Pack)
        {
            _donkeyCount++;
        }

        public Donkey()
        {
            
        }

        public static int DonkeysCount
        {
            get => _donkeyCount;
            set => _donkeyCount = value;
        }

        public override string ToString()
        {
            return $"Осел: " + base.ToString();
        }
    }
}
