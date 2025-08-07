namespace Benchy.Solutions;

public class Sergey2(int length) : ITask0
{
    private record struct Cell(int Version, int Value);
    
    private readonly Cell[] _array = new Cell[length];

    private int _defaultValue;
    private int _version;

    public void SetCell(int value, int index)
    {
        _array[index] = new Cell(_version, value);
    }

    public int GetCell(int index)
    {
        var cell = _array[index];
        return cell.Version < _version ? _defaultValue : cell.Value;
    }

    public void SetAllCells(int value)
    {
        _defaultValue = value;
        _version++;
    }
}