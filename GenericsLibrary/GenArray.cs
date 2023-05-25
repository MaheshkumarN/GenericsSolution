namespace GenericsLibrary
{
  public class GenArray<T>
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

    //public void Sort()
    //{
    //  for (int i = 0; i < _position; i++)
    //  {
    //    for (int j = (i+1); j < _position; j++)
    //    {
    //      if (_array[i] > _array[i]) // Will have to use Constraint
    //      {
    //        T temp = _array[i];
    //        _array[i] = _array[j];
    //        _array[j] = temp;
    //      }
    //    }
    //  }
    //}

  }
}
