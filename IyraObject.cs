namespace Iyra
{
    public abstract class IyraObject<T> where T : IyraObject<T>
    {
        protected readonly T self;
        protected IyraObject()
        {
            self = (T)this;
        }
    }
}
