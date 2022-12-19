using ComponentBasedUI.EventListeners.Core;
using ComponentBasedUI.Events.Core;
using UnityEngine;

namespace ComponentBasedUI.EventListeners
{
    public abstract class MonoEventListener : EventListener
    {
        [Header("Listener Event")]
        [SerializeField] protected MonoEvent _monoEvent;

        #region MonoBehaviour

        protected override void OnValidate()
        {
            base.OnValidate();
            
            _monoEvent ??= GetComponent<MonoEvent>();
        }

        #endregion
        
        protected override void AddListener()
        {
            _monoEvent.onMonoCall += OnMonoCall;
        }

        protected override void RemoveListener()
        {
            _monoEvent.onMonoCall -= OnMonoCall;
        }

        private void OnMonoCall()
        {
            OnEventFired();
            
            Invoke();
        }
        
        protected abstract void OnEventFired();
    }
}
