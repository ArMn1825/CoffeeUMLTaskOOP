public abstract class Ingredient: IElement
{
    public double Mass { get; set; }
    public abstract string GetInfo();
    protected Ingredient(double mass)
    {
        Mass = mass >= 0 ? mass : 0;
    }
}
