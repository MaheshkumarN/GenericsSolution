namespace GenericsClientConApp
{
  public class Person: IComparable<Person>
  {
    int _age;
    string _name;
    public Person(int age, string name)
    {
      _age = age;
      _name = name;
    }

    public int Age { get { return _age; } set { _age = value; } }
    public string Name { get { return _name; } set { _name = value; } }

    public int CompareTo(Person person)
    {
      return _name.CompareTo(person._name);
    }

    public override string ToString()
    {
      return $"Name: {_name} and Age: {_age}";
    }
  }
}
