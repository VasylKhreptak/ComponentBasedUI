using ComponentBasedUI.EventListeners;
using NaughtyAttributes;
using UnityEngine;
using Action = ComponentBasedUI.Actions.Core.Action;

namespace ComponentBasedUI.Actions.General
{
    public class OnEventDoAction : MonoEventListener
    {
        [Header("References")]
        [Required, SerializeField] private Action _action;

        #region MonoBehaviour

        protected override void OnValidate()
        {
            base.OnValidate();

            _action ??= GetComponent<Action>();
        }

        protected override void OnEventFired()
        {
            _action.Do();
        }

        #endregion
    }
}
