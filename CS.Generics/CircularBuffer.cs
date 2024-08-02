namespace CS.Generics;

public class CircularBuffer<T>
{
    private T[] _buffer;
    private int _readIdx;
    private int _writeIdx;        

    public CircularBuffer(int capacity)
    {            
        _buffer = new T[capacity+1];
    }

    public void Write(T item)
    {
        _buffer[_writeIdx] = item;
        _writeIdx = (_writeIdx + 1) % _buffer.Length;

        if (_readIdx == _writeIdx)
        {
            _readIdx = (_readIdx + 1) % _buffer.Length;
        }
    }

    public T Read()
    {
        T value = _buffer[_readIdx];
        _readIdx = (_readIdx + 1) % _buffer.Length;
        return value;
    }
}