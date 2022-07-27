using System.Collections.Generic;
using Extensions;
using UnityEngine;

namespace Core
{
    public abstract class BaseState : MonoBehaviour
    {
        [SerializeField] [Config] private List<StateTrigger> onEnable;
        [SerializeField] [Config] private List<StateTrigger> onDisable;

        protected abstract void EnterState();
        protected abstract void ExitState();
        
        protected virtual void OnEnable()
        {
            EnterState();
            onEnable.Run();
        }

        protected virtual void OnDisable()
        {
            ExitState();
            onDisable.Run();
        }
    }
}