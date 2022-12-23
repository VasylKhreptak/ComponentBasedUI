using CBA.EventListeners.Core;
using CBA.Events.Core;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.EventListeners
{
    public abstract class MonoEventListener : EventListener
    {
        [Header("Listener Event")]
        [Required, SerializeField] protected MonoEvent _monoEvent;

        #region MonoBehaviour

        protected override void OnValidate()
        {
            base.OnValidate();
            
            _monoEvent ??= GetComponent<MonoEvent>();
            _monoEvent = _monoEvent == this ? null : _monoEvent;
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
