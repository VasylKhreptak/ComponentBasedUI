using System;
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

        private bool _addedListener;
        
        #region MonoBehaviour

        protected virtual void OnValidate()
        {
            if (_listenerType == ListenerType.Editor)
            {
                TryAddListener();
            }
            else if (_listenerType != ListenerType.Editor)
            {
                TryRemoveListener();
            }
        }

        protected virtual void Awake()
        {
            if (_listenerType == ListenerType.AwakeDestroy)
            {
                TryAddListener();
            }
            else if (_listenerType == ListenerType.Manual)
            {
                _addListenerEvent.onMonoCall += TryAddListener;
                _removeListenerEvent.onMonoCall += TryRemoveListener;
            }
        }

        protected virtual void Start()
        {
            if (_listenerType == ListenerType.StartDestroy)
            {
                TryAddListener();
            }
        }

        protected virtual void OnEnable()
        {
            if (_listenerType == ListenerType.EnableDisable)
            {
                TryAddListener();
            }
        }

        protected virtual void OnDisable()
        {
            if (_listenerType == ListenerType.EnableDisable)
            {
                TryRemoveListener();
            }
        }

        protected virtual void OnDestroy()
        {
            if (_listenerType == ListenerType.AwakeDestroy ||
                _listenerType == ListenerType.StartDestroy)
            {
                TryRemoveListener();
            }
            else if (_listenerType == ListenerType.Manual)
            {
                _addListenerEvent.onMonoCall -= TryAddListener;
                _removeListenerEvent.onMonoCall -= TryRemoveListener;
            }
        }

        #endregion

        private void TryAddListener()
        {
            if (_addedListener == false)
            {
                AddListener();

                _addedListener = true;
                
                Debug.Log("Added Listener!");
            }
        }

        private void TryRemoveListener()
        {
            if (_addedListener)
            {
                RemoveListener();

                _addedListener = false;
                
                Debug.Log("Removed Listener!");
            }
        }
        
        protected abstract void AddListener();

        protected abstract void RemoveListener();
    }
}
