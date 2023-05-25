namespace GenericsLibrary
{
  public class SwapTool
  {
    public void Swap(int value1, int value2)
    {
      int temp = value1;
      value1 = value2;
      value2 = temp;
    }

    public void Swap(ref int value1, ref int value2)
    {
      int temp = value1;
      value1 = value2;
      value2 = temp;
    }

  }
}