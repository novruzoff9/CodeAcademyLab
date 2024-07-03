using FactoryMethodMrPos.Factory;

namespace FactoryMethodMrPos;

internal class Program
{
    static void Main(string[] args)
    {
        FoodFactory pizza = new PizzaFactory("Peperonni", 15);
        pizza.OrderFood();

        /*
            Peperonni Pizza
            Inqrediyentler artirilir
            15 deqiqe sobada bisirilir
        */

        FoodFactory pasta = new PastaFactory("Bolonez", 10);
        pasta.OrderFood();

        /*
            Bolonez Pasta
            Inqrediyentler artirilir
            10 deqiqe qazanda qaynadilir
         */

        FoodFactory desert = new DesertFactory("Dondurma", "Ciyelek");
        desert.OrderFood();

        /*
            Dondurma Desert
            Ciyelek ile dadlandir
            Servis et
         */
    }
}
