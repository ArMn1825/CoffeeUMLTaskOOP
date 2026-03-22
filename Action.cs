public abstract class Action : IElement
{
    private readonly List<IElement> _elements = new List<IElement>();
    public IReadOnlyList<IElement> Elements => _elements.AsReadOnly();
    public Action(List<IElement> elements)
    {
        foreach (var elem in elements)
        {
            Add(elem);
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
    public abstract void Execute();
    public abstract string GetInfo();
}
