using UnityEngine;
using Action = ComponentBasedUI.Actions.Core.Action;

namespace ComponentBasedUI.Actions.Mono.Core
{
    public class ActionContainer : MonoBehaviour
    {
        [Header("Action")]
        [SerializeField] protected Action _action;

        #region MonoBehaviour

        private void OnValidate()
        {
            _action ??= GetComponent<Action>();
        }

        #endregion
    }
}
