public class Drink
{
    public IElement ?Recipe { get; set; }
    public Drink(IElement ?recipe = null)
    {
        Recipe = recipe;
    }
}
