using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay.Views.SampleScene
{
    public class ChangeTimeUiView : MonoBehaviour
    {
        public event Action OnChangeTime;
        
        [SerializeField] private Button _changeTimeButton;

        private void OnEnable()
        {
            _changeTimeButton.onClick.AddListener(OnChangeTimeButtonClickHandler);
        }

        private void OnDisable()
        {
            _changeTimeButton.onClick.RemoveListener(OnChangeTimeButtonClickHandler);
        }

        private void OnChangeTimeButtonClickHandler()
        {
            OnChangeTime?.Invoke();
        }
    }
}