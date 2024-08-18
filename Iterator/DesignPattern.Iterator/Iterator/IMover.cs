namespace DesignPattern.Iterator.Iterator
{
    public interface IMover<T>
    {
        IIterator<T> CreateIterator();

    }
}
