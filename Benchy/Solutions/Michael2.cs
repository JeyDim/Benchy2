namespace Benchy.Solutions;

public class Michael2(int length) : ITask0
{
    private readonly int[] _array = new int[length];
    private int? _allCellsValue;
    private HashSet<int> _indexes = [];

    public void SetCell(int value, int index)
    {
        _array[index] = value;

        if (_allCellsValue != null)
            _indexes.Add(index);
    }

    public int GetCell(int index)
    {
        if (_allCellsValue == null)
            return _array[index];

        return !_indexes.Contains(index) ? _allCellsValue.Value : _array[index];
    }

    public void SetAllCells(int value)
    {
        _allCellsValue = value;
        _indexes = [];
    }
}