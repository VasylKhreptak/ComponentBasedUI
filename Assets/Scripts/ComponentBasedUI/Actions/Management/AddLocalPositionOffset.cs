using ComponentBasedUI.Actions.Management.Core;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management
{
    public class AddLocalPositionOffset : TransformAction
    {
        [Header("Preferences")]
        [SerializeField] private Vector3 _localPositionOffset;

        public override void Do()
        {
            _transform.localPosition += _localPositionOffset;
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;
        [ShowNonSerializedField] private Vector3 _startLocalPosition;

        [Button("Start Recording")]
        private void StartRecording()
        {
            _startLocalPosition = _transform.localPosition;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            _localPositionOffset = _transform.localPosition - _startLocalPosition;
            _transform.localPosition = _startLocalPosition;

            _isRecording = false;
        }

        private void OnDrawGizmosSelected()
        {
            Transform parent = _transform.parent;

            if (_transform == null || parent == null) return;

            if (_isRecording)
            {
                OnRecording(parent);
            }
            else
            {
                DrawArrow(parent);
            }
        }

        private void OnRecording(Transform parent)
        {
            Vector3 startPosition = parent.TransformPoint(_startLocalPosition);
            Vector3 targetPosition = parent.TransformPoint(_transform.localPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.red;
            Gizmos.DrawSphere(startPosition, 0.1f);
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

        private void DrawArrow(Transform parent)
        {
            Vector3 localPosition = _transform.localPosition;
            Vector3 startPosition = parent.TransformPoint(localPosition);
            Vector3 targetPosition = parent.TransformPoint(localPosition + _localPositionOffset);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion
    }
}
