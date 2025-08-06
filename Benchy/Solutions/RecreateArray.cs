namespace Benchy.Solutions;

public class RecreateArray(int length) : ITask0
{
    private int[] _array = new int[length];

    public void SetCell(int value, int index) => _array[index] = value;

    public int GetCell(int index) =>  _array[index];

    public void SetAllCells(int value) => _array = Enumerable.Repeat(value, length).ToArray();
}