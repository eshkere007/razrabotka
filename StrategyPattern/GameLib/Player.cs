namespace GameLib
{
    public class Player
    {
        private IWeapon _weapon;

        public Player(IWeapon initialWeapon)
        {
            _weapon = initialWeapon;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
            Console.WriteLine("Смена мегаоружия");
        }

        public void Attack()
        {
            if (_weapon == null)
            {
                Console.WriteLine("Возьмите мегаоружие!");
            }
            else
            {
                _weapon.UseWeapon();
            }
        }
    }

}
