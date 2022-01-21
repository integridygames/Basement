namespace Game.Core.Base
{
    public abstract class ControllerBase<T>
    {
        protected readonly T Data;

        protected ControllerBase(T data)
        {
            Data = data;
        }
    }
}