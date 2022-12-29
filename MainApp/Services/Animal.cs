public abstract class Animal
{
    public string Name { get; set; }

    public void SetName(string name)
    {
        Name = name; 
    }
    public string GetName()
    {
        return Name;
    }
    public abstract string Eat();
}

public class Dog : Animal
{
    public override string Eat()
    {
        return $"{Name} is eating.";
    }
}