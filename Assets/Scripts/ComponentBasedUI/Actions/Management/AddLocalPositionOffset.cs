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
        [ShowNonSerializedField] private bool _movedToStart;
        [ShowNonSerializedField] private bool _movedToEnd;

        [Button("Start Recording")]
        private void StartRecording()
        {
            if (_isRecording) return;

            _startLocalPosition = _transform.localPosition;

            _isRecording = true;
            _movedToEnd = false;
            _movedToStart = false;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _localPositionOffset = _transform.localPosition - _startLocalPosition;
            _transform.localPosition = _startLocalPosition;

            _isRecording = false;
            _movedToEnd = false;
            _movedToStart = false;
        }

        [Button("Move To End")]
        private void MoveToEnd()
        {
            if (_isRecording || _movedToEnd) return;

            _startLocalPosition = _transform.localPosition;

            _transform.localPosition = _startLocalPosition + _localPositionOffset;

            _movedToEnd = true;
            _movedToStart = false;
        }

        [Button("Move To Start")]
        private void MoveToStart()
        {
            if (_isRecording || _movedToStart || _movedToEnd == false) return;

            _transform.localPosition = _startLocalPosition;

            _movedToStart = true;
            _movedToEnd = false;
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

                if (_movedToEnd)
                {
                    Vector3 pointCenter = parent.TransformPoint(_startLocalPosition);
                    
                    Gizmos.color = Color.white;
                    DrawPoint(ref pointCenter);
                }
            }
        }

        private void OnRecording(Transform parent)
        {
            Vector3 startPosition = parent.TransformPoint(_startLocalPosition);
            Vector3 targetPosition = parent.TransformPoint(_transform.localPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.red;
            DrawPoint(ref startPosition);
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

        private void DrawPoint(ref Vector3 position)
        {
            Gizmos.DrawSphere(position, 0.1f);
        }
        
#endif

        #endregion
    }
}
