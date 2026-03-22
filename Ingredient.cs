public abstract class Ingredient: IElement
{
    private double _mass;
    public double Mass
    {
        get => _mass;
        set
        {
            _mass = value >= 0 ? value : 0;
        }
    }
    public abstract string GetInfo();
    protected Ingredient(double mass)
    {
        Mass = mass;
    }
}
