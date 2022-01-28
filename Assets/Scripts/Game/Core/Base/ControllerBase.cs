using UnityEngine;

namespace Game.Core.Base
{
    public abstract class ControllerBase<T> where T : MonoBehaviour
    {
        protected readonly T View;

        protected ControllerBase(T view)
        {
            View = view;
        }
    }
}