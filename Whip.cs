public class Whip : Action
{
    public Whip(List<IElement> ?elements = null) : base(elements) {}
    public Whip() : base(null) {}
    public override string GetInfo() => "Whiping ingredients";
    public override void Execute()
    {
        Console.Out.WriteLine("Whiping:\n");
        ExecuteElements();
        if (ContainsIngredient<Milk>())
        {
            Console.Out.WriteLine("Whiping completed successfully!");
        }
        else
        {
            Console.Out.WriteLine("Whipping has no effect/");
        }
    }
}
