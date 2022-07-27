using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core
{
    [Serializable]
    public class StateTrigger
    {
        [HideLabel] [HorizontalGroup(0.5f)] [SerializeField] private BaseState state;
        [HideLabel] [HorizontalGroup(0.5f)] [SerializeField] private bool enabled = true;

        public void Run()
        {
            state.enabled = enabled;
        }
    }
}