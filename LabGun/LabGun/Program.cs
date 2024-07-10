using LabGun.Models;

namespace LabGun;

internal class Program
{
    static void Main(string[] args)
    {
        Gun ak47 = new Gun();
        ak47.Type = LabGun.Models.Type.Assault_Rifle;
        ak47.MagazineSize = 40;
        ak47.CurrentBullet = 32;
        ak47.BulletperMSecond = 3;

        Console.WriteLine(ak47.CurrentBullet);

        Gun mk48 = new Gun();
        mk48.Type = LabGun.Models.Type.Light_Machine_Gun;
        mk48.MagazineSize = 120;
        mk48.CurrentBullet = 80;
        mk48.BulletperMSecond = 6;

        Gun avm = new Gun();
        avm.Type = LabGun.Models.Type.Sniper_Rifle;
        avm.MagazineSize = 8;
        avm.CurrentBullet = 4;
        avm.BulletperMSecond = 1;

        Gun S12 = new Gun();
        S12.Type = LabGun.Models.Type.Shotgun;
        S12.MagazineSize = 4;
        S12.CurrentBullet = 1;
        S12.BulletperMSecond = 1;


        Console.WriteLine($"Avm gülle sayı {avm.CurrentBullet}");
        avm.MonoMode(6);
        Console.WriteLine($"Avm gülle sayı {avm.CurrentBullet}");

        Console.WriteLine();

        Console.WriteLine($"MK48 gülle sayı {mk48.CurrentBullet}");
        mk48.PoloMode(8);
        Console.WriteLine($"MK48 gülle sayı {mk48.CurrentBullet}");
        mk48.FullCharge();
        Console.WriteLine($"MK48 gülle sayı {mk48.CurrentBullet}");




        Gun assault = new AssaultRiffle();
        assault.Type = Models.Type.Assault_Rifle;
        assault.MagazineSize = 10;
        assault.CurrentBullet = 4;
        Console.WriteLine(assault.CurrentBullet);
        assault.CustomizeGun();

        Gun sniper = new Sniper();
        sniper.Type = LabGun.Models.Type.Sniper_Rifle;
        sniper.MagazineSize = 8;
        sniper.CurrentBullet = 4;
        sniper.BulletperMSecond = 4;
        sniper.CustomizeGun();
        Console.WriteLine($"sniper gulle per millisecond {sniper.BulletperMSecond}");
    }
}
