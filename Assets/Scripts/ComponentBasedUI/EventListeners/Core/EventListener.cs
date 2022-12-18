using UnityEngine;

namespace ComponentBasedUI.EventListeners.Core
{
    public abstract class EventListener : MonoBehaviour
    {
        [Header("Listener Preferences")]
        [SerializeField] protected ListenerType _listenerType;

        #region MonoBehaviour

        protected virtual void Awake()
        {
            if (_listenerType == ListenerType.AwakeDestroy)
            {
                AddListener();
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
            }
        }

        #endregion
        
        protected abstract void AddListener();
        
        protected abstract void RemoveListener();
    }
}
