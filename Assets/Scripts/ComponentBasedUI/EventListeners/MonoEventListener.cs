using ComponentBasedUI.EventListeners.Core;
using ComponentBasedUI.MonoEvents.Core;
using UnityEngine;

namespace ComponentBasedUI.EventListeners
{
    public abstract class MonoEventListener : EventListener
    {
        [Header("Listener Event")]
        [SerializeField] protected MonoEvent _monoEvent;

        #region MonoBehaviour

        protected virtual void OnValidate()
        {
            _monoEvent ??= GetComponent<MonoEvent>();
        }

        #endregion
        
        protected override void AddListener()
        {
            _monoEvent.onMonoCall += OnEventFired;
        }

        protected override void RemoveListener()
        {
            _monoEvent.onMonoCall -= OnEventFired;
        }
        
        protected abstract void OnEventFired();
    }
}
