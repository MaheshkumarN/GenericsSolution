namespace GenericsLibrary
{

  //Step I
  public delegate bool CompareFN<S>(S value1, S value2);

  public class GenArray<T> where T : IComparable<T>
  {
    int _arraySize;
    int _position;
    T[] _array;

    public GenArray()
    {
      _arraySize = 3;
      _position = 0;
      _array = new T[_arraySize];
    }

    public int Length { get { return _position; } }

    public T this[int position]
    {
      get
      {
        if (position >= _position)
        {
          throw new IndexOutOfRangeException($"No data found at the position: '{position}'");
        }
        return _array[position];
      }
    }

    public void Add(T value)
    {
      _array[_position++] = value;
      if (_position == _arraySize)
      {
        _arraySize += 3;
        T[] temp = new T[_arraySize];
        for (int i = 0; i < _position; i++)
        {
          temp[i] = _array[i];
        }
        _array = temp;
      }
    }

    public void Sort()
    {
      for (int i = 0; i < _position; i++)
      {
        for (int j = (i + 1); j < _position; j++)
        {
          //if (_array[i] >_array[j]) // Will have to use Constraint
            if (_array[i].CompareTo(_array[j]) > 0) 
            {
              T temp = _array[i];
            _array[i] = _array[j];
            _array[j] = temp;
          }
        }
      }
    }
    
    // Step II
    public void Sort(CompareFN<T> del)
    {
      for (int i = 0; i < _position; i++)
      {
        for (int j = (i + 1); j < _position; j++)
        {

          //if (_array[i].CompareTo(_array[j]) > 0) 
          // Step III
          if (del(_array[i],_array[j]))
          {
              T temp = _array[i];
            _array[i] = _array[j];
            _array[j] = temp;
          }
        }
      }
    }

  }
}
