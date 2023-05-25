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

    // Step I
    public static bool CompareByName(Person p1, Person p2)
    {
      if(p1._name.CompareTo(p2._name) > 0)
        return true;
      return false;
    }

    public static bool CompareByAge(Person p1, Person p2)
    {
      if(p1._age > p2._age)
        return true;
      return false;
    }

  }
}
