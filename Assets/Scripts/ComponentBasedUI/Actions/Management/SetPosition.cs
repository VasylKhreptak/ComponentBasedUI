using ComponentBasedUI.Actions.Management.Core;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management
{
    public class SetPosition : TransformAction
    {
        [Header("Preferences")]
        [SerializeField] private Vector3 _position;

        public override void Do()
        {
            _transform.position = _position;
        }

        #region Editor

#if UNITY_EDITOR

        [Button("Assign Position")]
        private void AssignPositionVariable()
        {
            _position = _transform.position;
        }
        
        private void OnDrawGizmosSelected()
        {
            if (_transform == null) return;

            DrawArrow();
        }

        private void DrawArrow()
        {
            Vector3 startPosition = _transform.position;
            Vector3 direction = _position - startPosition;

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }
#endif

        #endregion
    }
}
