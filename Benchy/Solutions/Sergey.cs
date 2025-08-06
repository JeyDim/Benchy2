namespace Benchy.Solutions;

public class Sergey(int length) : ITask0
{
    private readonly int[] _array = new int[length];

    private int _defaultValue;
    private int _version;
    private readonly int[] _cellVersions = new int[length];

    public void SetCell(int value, int index)
    {
        _array[index] = value;
        _cellVersions[index] = _version;
    }

    public int GetCell(int index) => _version != _cellVersions[index] ? _defaultValue : _array[index];

    public void SetAllCells(int value)
    {
        _defaultValue = value;
        _version++;
    }
}