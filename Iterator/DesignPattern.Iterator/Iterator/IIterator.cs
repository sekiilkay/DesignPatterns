namespace DesignPattern.Iterator.Iterator
{
    public interface IIterator<T>
    {
        T CurrentItem { get; }
        bool NextLocation();

    }
}
