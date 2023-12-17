
namespace Animal_Registry.Model
{
    abstract internal class Animal
    {
        private string _name;

        private string _birthday;

        private List<string> _commands = new List<string>();

        private Type _type;

        static private int _count = 0;
        public string Name 
        { 
            get => _name; 
            set
            {
                if(value == string.Empty)
                {
                    Console.WriteLine("Имя не может быть пустым.");
                    return;
                }
                _name =  value.Trim();
            } 
        }
        public string Birthday 
        { 
            get => _birthday; 
            set
            {
                if(value == string.Empty)
                {
                    Console.WriteLine("Дата рождения не может быть пустой.");
                    return;
                }
                _birthday = value.Trim();
            }
        }
        internal Type Type { get => _type; }
        public string Commands 
        { 
            get => string.Join(", ", _commands);
        }

        public static int Count 
        { 
            get => _count;
        }

        public Animal(string name, string birthday, Type type)
        {
            Name = name;
            Birthday = birthday;
            _type = type;
            _count++;
        }

        public Animal()
        {
            
        }

        /// <summary>
        /// Добавление новой команды к животному
        /// </summary>
        /// <param name="command"></param>
        public void AddNewCommand(string command)
        {
            if(Commands.Contains(command))
            {
                Console.WriteLine("Команда уже существует");
                Console.ReadLine();
                return;
            }
            else if(command == string.Empty)
            {
                Console.WriteLine("Пустое поле с командой");
                Console.ReadLine();
                return;
            }
            _commands.Add(command.Trim());
        }

        public override string ToString()
        {
            return $"| имя - {_name} | дата рождения - {_birthday}.";
        }
    }
}
