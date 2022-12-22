using NaughtyAttributes;
using UnityEngine;
using Action = ComponentBasedUI.Actions.Core.Action;

namespace ComponentBasedUI.Actions.Management.Core
{
    public abstract class TransformAction : Action
    {
        [Header("References")]
        [Required, SerializeField] protected Transform _transform;

        [Header("Axes")]
        [SerializeField] protected Vector3Int _axes = Vector3Int.one;

        #region MonoBehaviour

        protected virtual void OnValidate()
        {
            _transform ??= GetComponent<Transform>();
            
            _axes = Extensions.Vector3Int.ClampComponents01(_axes);
        }

        #endregion
    }
}
