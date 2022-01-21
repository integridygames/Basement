using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Gameplay.Views.SampleScene
{
    public class TimeUiView : MonoBehaviour
    {
        [SerializeField] private Text _timeText;

        public void SetTime(float time)
        {
            _timeText.text = TimeSpan.FromHours(time).ToString(@"hh\:mm");
        }
    }
}