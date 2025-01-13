using Weapon;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player();

        Console.WriteLine($"У игрока {player.getSlotsCount()} слотов с оружием введите номер чтобы выстрелить, -1 чтобы выйти");
        while (true)
        {
            try
            {
                int slot = Convert.ToInt32(Console.ReadLine());
                if (slot == -1) break;
                player.shotWithWeapon(slot);
            }
            catch { Console.WriteLine("Неверный ввод"); continue; }
        }
        Console.WriteLine("Game over!");
        Console.ReadLine();
    }
}
class Player
{
    private weapon[] weaponSlots;
    public Player()
    {
        weaponSlots = new weapon[5];
        weaponSlots[0] = new waterGun();
        weaponSlots[1] = new Gun();
        weaponSlots[2] = new Automat();
        weaponSlots[3] = new RPG();
        weaponSlots[4] = new Rogatka();
    }
    public int getSlotsCount()
    {
        return weaponSlots.Length;
    }
    public void shotWithWeapon(int slot)
    {
        if (1 > slot || slot > weaponSlots.Length ) { Console.WriteLine("Введёное число не входит в диапазон слотов оружия"); return; }
        weapon weapon = weaponSlots[slot-1];
        Console.WriteLine(weapon.shot);
    }
}
