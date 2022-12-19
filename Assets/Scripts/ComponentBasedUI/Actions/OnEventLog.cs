using ComponentBasedUI.EventListeners;
using UnityEngine;

namespace ComponentBasedUI.Actions
{
    public class OnEventLog : MonoEventListener
    {
        [Header("Preferences")]
        [SerializeField] private string _message;
    
        protected override void OnEventFired()
        {
            Debug.Log(_message);
        }
    }
}
