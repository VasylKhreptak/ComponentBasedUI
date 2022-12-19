using UnityEngine;
using Action = ComponentBasedUI.Actions.Core.Action;

namespace ComponentBasedUI.Actions.Management.Core
{
    public abstract class TransformAction : Action
    {
        [Header("References")]
        [SerializeField] protected Transform _transform;

        #region MonoBehaviour

        private void OnValidate()
        {
            _transform ??= GetComponent<Transform>();
        }

        #endregion
    }
}
