using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGun.Models;

public enum Type
{
    Assault_Rifle,
    Shotgun,
    Light_Machine_Gun,
    Sniper_Rifle
}

public class Gun
{
    public Type Type { get; set; }

    private int _MagazineSize;
    public int MagazineSize
    {
        get { return _MagazineSize; }
        set { 
            if(value < 0)
            {
                throw new Exception("Magazin ölçüsü mənfi qiymət ala bilməz");
            }
            else
            {
                _MagazineSize = value;
            }
        }
    }

    private int _CurrentBullet;

    public int CurrentBullet
    {
        get { return _CurrentBullet; }
        set { 
            if(value < 0)
            {
                throw new Exception("Hazırki güllə sayı mənfi ola bilməz");
            }
            else if (value > this.MagazineSize)
            {
                throw new Exception("Gulle sayi magazin tutumundan çox ola bilməz");
            }
            else
            {
                _CurrentBullet = value;
            }
        }
    }
    public int BulletperMSecond { get; set; }


    public void MonoMode(int bullet)
    {
        if(this.CurrentBullet >= bullet)
        {
            this.CurrentBullet -= bullet;
            Console.WriteLine($"Nəzərdə tutulan {bullet} atış yerinə yetirildi.\nMaqazində {this.CurrentBullet} güllə qaldı.");
        }
        else if(this.CurrentBullet < bullet)
        {
            Console.WriteLine($"Maqzindəki güllə sayı nəzərdə tutulandan az olduğu üçün {bullet - this.CurrentBullet} atış əksik oldu.");
            this.CurrentBullet = 0;
        }
    }

    public void PoloMode(int millisecond)
    {
        int totalbullet = millisecond * this.BulletperMSecond;
        if (this.CurrentBullet >= totalbullet)
        {
            this.CurrentBullet -= totalbullet;
            Console.WriteLine($"Nəzərdə tutulan {millisecond} millisaniyəlik atış yerinə yetirildi.\nÜmumi {totalbullet} güllə istifadə olundu.\nMaqazində {this.CurrentBullet} güllə qaldı.");
        }
        else if (this.CurrentBullet < totalbullet)
        {
            int firedseconds = this.CurrentBullet / this.BulletperMSecond;
            Console.WriteLine($"Maqzindəki güllə sayı nəzərdə tutulandan az olduğu üçün atış {firedseconds} millisaniyəlik atış həyata keçirildi.");
            this.CurrentBullet = 0;
        }
    }

    public void FullCharge()
    {
        int requirebulet = this.MagazineSize - this.CurrentBullet;
        Console.WriteLine($"Silahin maqazini tamamilə dolduruldu.\nDoldurulma üçün {requirebulet} güllə istifadə olundu.");
        this.CurrentBullet = this.MagazineSize;
    }

    public virtual void CustomizeGun()
    {
        Console.WriteLine("Base Customize");
    }
}
