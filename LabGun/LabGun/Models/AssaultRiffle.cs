using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGun.Models;

public class AssaultRiffle : Gun
{
    public double RecoilRate { get; set; }

    public override void CustomizeGun()
    {
        Console.WriteLine(
            "Silaha artırmaq istədiyiniz Eklentini seçin:\n" +
            "1. Scope\n" +
            "2. Grip\n"
            );

        int attachmenttype = Convert.ToInt32(Console.ReadLine());

        if (attachmenttype == 1)
        {
            Console.WriteLine(
            "Silaha artırmaq istədiyiniz Scope-u seçin:\n" +
            "1. ACOG\n" +
            "2. MILLIMETER SCANNER\n"
            );

            int selectcedattachment = Convert.ToInt32(Console.ReadLine());

            if (selectcedattachment == 1)
            {
                Console.WriteLine("Dusmeni daha rahat secirsen");
            }
            else if (selectcedattachment == 2)
            {
                Console.WriteLine("Divar arxasi goreceksen");
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
