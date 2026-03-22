public class Pour : Action
{
    public Pour(List<IElement> ?elements = null) : base(elements) {}
    public Pour() : base(null) {}
    public override string GetInfo() => "Pouring ingredients";
    public override void Execute()
    {
        Console.Out.WriteLine("\nPouring:");
        ExecuteElements();
        bool has_dry_beans = false;
        foreach (var elem in Elements)
        {
            if (elem is CoffeeBean ||
                elem is Action act && act.ContainsIngredient<CoffeeBean>() &&
                !act.ContainsIngredient<Water>() && !act.ContainsIngredient<Milk>() &&
                !act.ContainsIngredient<Syrup>())
            {
                has_dry_beans = true;
                break;
            }
        }
        if (has_dry_beans && ContainsIngredient<Water>())
        {
            Console.Out.WriteLine("Pouring completed successfully!");
        }
        else
        {
            Console.Out.WriteLine("Pouring is impossible.");
        }
    }
}
