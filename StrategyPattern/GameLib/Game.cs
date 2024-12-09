namespace GameLib
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            _player = new Player(new Sword());
        }

        public void Start()
        {
            Console.WriteLine("Вы вооружены мегамечом");
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Атаковать");
                Console.WriteLine("2. Сменить мегаоружие");
                Console.WriteLine("3. Выйти");

                string input = Console.ReadLine();

                if (input == "1") _player.Attack();
                else if (input == "2") ChangeWeapon();
                else if (input == "3")
                {
                    Console.WriteLine("Мегаигра завершена");
                    return;
                }
                else Console.WriteLine("Такого варианта нет");
            }
        }

        private void ChangeWeapon()
        {
            Console.WriteLine("\nВыберите оружие:");
            Console.WriteLine("1. Меч");
            Console.WriteLine("2. Лук");
            Console.WriteLine("3. Топор");

            string input = Console.ReadLine();

            if (input == "1") _player.SetWeapon(new Sword());
            else if (input == "2") _player.SetWeapon(new Bow());
            else if (input == "3") _player.SetWeapon(new Axe());
            else Console.WriteLine("Такого нет, оружие осталось прежним");
        }
    }

}
