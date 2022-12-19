using ComponentBasedUI.Actions.Management.Core;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management
{
    public class AddPositionOffset : TransformAction
    {
        [Header("Preferences")]
        [SerializeField] private Vector3 _offset;

        public override void Do()
        {
            _transform.position += _offset;
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;
        [ShowNonSerializedField] private Vector3 _startPosition;

        [Button("Start Recording")]
        private void StartRecording()
        {
            _startPosition = _transform.position;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            _offset = _transform.position - _startPosition;

            _transform.position = _startPosition;

            _isRecording = false;
        }

        private void OnDrawGizmosSelected()
        {
            if (_transform == null) return;

            if (_isRecording)
            {
                OnRecording();
            }
            else
            {
                DrawArrow();
            }
        }

        private void OnRecording()
        {
            Gizmos.color = Color.red;
            Extensions.Gizmos.DrawArrow(_startPosition, _transform.position - _startPosition);
            Gizmos.DrawSphere(_startPosition, 0.1f);
        }

        private void DrawArrow()
        {
            Vector3 startPosition = _transform.position;
            Vector3 targetPosition = startPosition + _offset;
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion
    }
}
