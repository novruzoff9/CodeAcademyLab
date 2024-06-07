namespace Polymorphism_.Models;

public class BasePhone
{
    public string Brand { get; set; }
    public string ConnectionType { get; set; }
    public virtual string Sound() => "Default sound";
}

public class MobilePhone : BasePhone
{
    public string OS { get; set; }
    public override string Sound()
    {
        return base.Sound();
    }
}

public class SmartPhone : MobilePhone
{
    public string Sound() => "Smart phone sound";
}