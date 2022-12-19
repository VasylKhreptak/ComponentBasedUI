using ComponentBasedUI.Actions.Management.Core;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management
{
    public class SetLocalPosition : TransformAction
    {
        [Header("Preferences")]
        [SerializeField] private Vector3 _localPosition;

        public override void Do()
        {
            _transform.localPosition = _localPosition;
        }

        #region Editor

#if UNITY_EDITOR

        [Button("Assign Local Position")]
        private void AssignLocalPositionVariable()
        {
            _localPosition = _transform.localPosition;
        }

        private void OnDrawGizmosSelected()
        {
            Transform parent = _transform.parent;

            if (_transform == null || parent == null) return;

            DrawArrow(parent);
        }

        private void DrawArrow(Transform parent)
        {
            Gizmos.color = Color.white;
            Vector3 localPosition = _transform.localPosition;
            Vector3 startPosition = parent.TransformPoint(localPosition);
            Vector3 targetPosition = parent.TransformPoint(_localPosition);
            Vector3 direction = targetPosition - startPosition;
            
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion
    }
}
