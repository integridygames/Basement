using System;

namespace Game.Core
{
    public class RxField<T>
    {
        public event Action<T> OnUpdate;

        private T _value;

        public T Value
        {
            set
            {
                _value = value;
                OnUpdate?.Invoke(_value);
            }
            get => _value;
        }

        public static implicit operator RxField<T>(T value) => new RxField<T>();
    }
}