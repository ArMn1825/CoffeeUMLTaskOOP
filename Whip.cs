public class Whip : Action
{
    public Whip(List<IElement> ?elements = null) : base(elements) {}
    public Whip() : base(null) {}
    public override string GetInfo() => $"PID {Id}: Whiping ingredients";
    public override void Execute()
    {
        ExecuteElements();
        CurrentExecutionInfo();
        if (ContainsIngredient<Milk>())
        {
            Console.Out.WriteLine("Whiping completed successfully!");
        }
        else
        {
            Console.Out.WriteLine("Whipping has no effect.");
        }
    }
}
