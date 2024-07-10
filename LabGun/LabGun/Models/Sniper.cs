using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGun.Models;

public class Sniper : Gun
{
    public override void CustomizeGun()
    {
        Console.WriteLine(
            "Silaha artırmaq istədiyiniz Eklentini seçin\n:" +
            "1. Scope\n" +
            "2. Mag\n"
            );

        int attachmenttype = Convert.ToInt32(Console.ReadLine());

        if (attachmenttype == 1)
        {
            Console.WriteLine(
            "Silaha artırmaq istədiyiniz Scope-u seçin\n:" +
            "1. 8x scope\n" +
            "2. Hybrid optic\n"
            );
            
            int selectcedattachment = Convert.ToInt32(Console.ReadLine());

            if(selectcedattachment == 1) 
            {
                Console.WriteLine("Daha uzunu goreceksen");
            }
            else if (selectcedattachment == 2)
            {
                Console.WriteLine("Enemy-ni daha rahat secessen");
            }
        }

        else if (attachmenttype == 2)
        {
            Console.WriteLine(
            "Silaha artırmaq istədiyiniz Mag-i seçin\n:" +
            "1. Extended mag\n" +
            "2. Fast mag\n"
            );

            int selectcedattachment = Convert.ToInt32(Console.ReadLine());

            if (selectcedattachment == 1)
            {
                base.MagazineSize = base.MagazineSize + base.MagazineSize / 2;
                Console.WriteLine("Magazinin tutumu 50% artdi");
            }
            else if (selectcedattachment == 2)
            {
                base.BulletperMSecond = base.BulletperMSecond + base.BulletperMSecond / 2;
                Console.WriteLine("Millisaniye basina gulle sayi 50% artdi");
            }
        }
    }
}
