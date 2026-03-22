public class Boil : Action
{
    public Boil(List<IElement> ?elements = null) : base(elements) {}
    public override string GetInfo() => "Boiling ingredients";
    public override void Execute()
    {
        Console.Out.WriteLine("Boiling:");
        ExecuteElements();
        if (ContainsIngredient<Water>() || ContainsIngredient<Ice>() || ContainsIngredient<Milk>())
        {
            Console.Out.WriteLine("Boiling completed successfully!");
            if (ContainsIngredient<Ice>())
            {
                Console.Out.WriteLine("Note: boiling ice may be a mistake");
                /* if execution should modify actual state of ingredients there will be change */
            }
        }
        else
        {
            Console.Out.WriteLine("BOILING FAILED! There is not liquid to boil");
        }
    }
}
