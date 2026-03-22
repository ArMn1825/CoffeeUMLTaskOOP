public class Grind : Action
{
    public Grind(List<IElement> ?elements = null) : base(elements) {}
    public Grind() : base(null) {}
    public override string GetInfo() => $"PID {Id}: Grinding ingredients";
    public override void Execute()
    {
        ExecuteElements();
        CurrentExecutionInfo();
        if (ContainsIngredient<CoffeeBean>())
        {
            Console.Out.WriteLine("Grinding completed successfully!");
        }
        else if (ContainsIngredient<Water>() || ContainsIngredient<Milk>() ||
                 ContainsIngredient<Ice>() || ContainsIngredient<Syrup>())
        {
            Console.Out.WriteLine("GRINDING IS IMPOSSIBLE!!! " +
                                  "Please remove dangerous ingredients from grinding machine!");
        }
        else
        {
            Console.Out.WriteLine("There is nothing to grind.");
        }
    }
}
