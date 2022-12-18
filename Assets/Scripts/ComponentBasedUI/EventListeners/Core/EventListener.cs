using ComponentBasedUI.MonoEvents;
using ComponentBasedUI.MonoEvents.Core;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.EventListeners.Core
{
    public abstract class EventListener : MonoBehaviour
    {
        [Header("Listener Preferences")]
        [SerializeField] protected ListenerType _listenerType;

        [Header("Manual Listener Preferences")]
        [ShowIf(nameof(CanShowManualControl)), SerializeField] private MonoEvent _addListenerEvent;
        [ShowIf(nameof(CanShowManualControl)), SerializeField] private MonoEvent _removeListenerEvent;

        private bool CanShowManualControl() => _listenerType == ListenerType.Manual;
        
        #region MonoBehaviour

        protected virtual void Awake()
        {
            if (_listenerType == ListenerType.AwakeDestroy)
            {
                AddListener();
                
                return;
            }

            if (_listenerType == ListenerType.Manual)
            {
                _addListenerEvent.onMonoCall += AddListener;
                _removeListenerEvent.onMonoCall += RemoveListener;
            }
        }

        protected virtual void Start()
        {
            if (_listenerType == ListenerType.StartDestroy)
            {
                AddListener();
            }
        }

        protected virtual void OnEnable()
        {
            if (_listenerType == ListenerType.EnableDisable)
            {
                AddListener();
            }
        }

        protected virtual void OnDisable()
        {
            if (_listenerType == ListenerType.EnableDisable)
            {
                RemoveListener();
            }
        }

        protected virtual void OnDestroy()
        {
            if (_listenerType == ListenerType.AwakeDestroy || 
                _listenerType == ListenerType.StartDestroy)
            {
                RemoveListener();
                
                return;
            }
            
            if (_listenerType == ListenerType.Manual)
            {
                _addListenerEvent.onMonoCall -= AddListener;
                _removeListenerEvent.onMonoCall -= RemoveListener;
            }
        }

        #endregion
        
        protected abstract void AddListener();
        
        protected abstract void RemoveListener();
    }
}
