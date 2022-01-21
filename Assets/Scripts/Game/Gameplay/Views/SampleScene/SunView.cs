using UnityEngine;

namespace Game.Gameplay.Views.SampleScene
{
    public class SunView : MonoBehaviour
    {
        [SerializeField] private Transform _sunTransform;

        public void SetAngle(float angle)
        {
            _sunTransform.transform.rotation = Quaternion.Euler(angle, 0, 0);
        }
    }
}