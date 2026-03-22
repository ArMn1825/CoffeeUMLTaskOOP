public class Grind : Action
{
    public Grind(List<IElement> ?elements = null) : base(elements) {}
    public Grind() : base(null) {}
    public override string GetInfo() => "Grinding ingredients";
    public override void Execute()
    {
        Console.Out.WriteLine("Grinding:\n");
        ExecuteElements();
        if (ContainsIngredient<CoffeeBean>())
        {
            Console.Out.WriteLine("Grinding completed successfully!");
        }
        else if (ContainsIngredient<Water>() || ContainsIngredient<Milk>() ||
                 ContainsIngredient<Ice>() || ContainsIngredient<Syrup>())
        {
            Console.Out.WriteLine("GRINDING IS IMPOSSIBLE!!!" +
                                  "Please remove dangerous ingredients from grinding machine!");
        }
        else
        {
            Console.Out.WriteLine("There is nothing to grind.");
        }
    }
}
