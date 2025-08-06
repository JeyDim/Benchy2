namespace Benchy.Solutions;

public class Naive(int length) : ITask0
{
    private readonly int[] _array = new int[length];

    public void SetCell(int value, int index) => _array[index] = value;

    public int GetCell(int index) =>  _array[index];

    public void SetAllCells(int value)
    {
        for (var i = 0; i < _array.Length; i++)
            _array[i] = value;
    }
}