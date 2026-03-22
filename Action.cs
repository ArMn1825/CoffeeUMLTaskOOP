public abstract class Action : IElement
{
    private static int _id_counter = 0;
    public int Id { get; private set; }
    private readonly List<IElement> _elements = new List<IElement>();
    public IReadOnlyList<IElement> Elements => _elements.AsReadOnly();
    public abstract void Execute();
    public abstract string GetInfo();
    public Action(List<IElement> ?elements = null)
    {
        Id = _id_counter;
        _id_counter++;
        if (elements != null)
        {
            foreach (var elem in elements)
            {
                Add(elem);
            }
        }
    }
    public void Add(IElement new_element)
    {
        if (!CreatesLoop(new_element))
        {
            _elements.Add(new_element);
        }
        else
        {
            Console.Error.WriteLine($"{new_element.GetInfo()} can't be added in action {this.GetInfo()}");
        }
    }
    public void Remove(IElement element)
    {
        if (_elements.Contains(element))
        {
            _elements.Remove(element);
        }
        else
        {
            Console.Error.WriteLine($"{element.GetInfo()} isn't in action {this.GetInfo()}");
        }
    }
    public bool ContainsIngredient<T>() where T : Ingredient
    {
        foreach (var elem in Elements)
        {
            if (elem is T)
            {
                return true;
            }
            else if (elem is Action act)
            {
                if (act.ContainsIngredient<T>())
                {
                    return true;
                }
            }
        }
        return false;
    }
    private bool CreatesLoop(IElement new_element)
    {
        if (new_element == this)
        {
            return true;
        }
        if (new_element is Action new_action)
        {
            foreach (IElement new_element_child in new_action.Elements)
            {
                if (CreatesLoop(new_element_child))
                {
                    return true;
                }
            }
        }
        return false;
    }
    protected void CurrentExecutionInfo()
    {
        Console.Out.WriteLine($"\n{GetInfo()}:");
        foreach (var elem in Elements)
        {
            Console.Out.WriteLine($"\t{elem.GetInfo()}");
        }
    }
    protected void ExecuteElements()
    {

        foreach (var elem in Elements)
        {
            if (elem is Action elem_act)
            {
                elem_act.Execute();
            }
        }
    }
}
