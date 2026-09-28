public abstract class Animal
{
    public string Name { get; set; } = string.Empty;
    public void SetName(string name)
    {
        Name = name;
    }
    public string GetName()
    {
        return Name;
    }
    public abstract void Eat();
}