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
        
        [ShowNonSerializedField] private Vector3 _startPosition;
        [ShowNonSerializedField] private bool _isRecording;
        [ShowNonSerializedField] private bool _movedToStart;
        [ShowNonSerializedField] private bool _movedToEnd;

        [Button("Assign Position")]
        private void AssignPosition()
        {
            _position = _transform.position;
        }
        
        [Button("Start Recording")]
        private void StartRecording()
        {
            if (_isRecording) return;

            _startPosition = _transform.position;

            _isRecording = true;
            _movedToEnd = false;
            _movedToStart = false;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _position = _transform.position;
            _transform.position = _startPosition;

            _isRecording = false;
            _movedToEnd = false;
            _movedToStart = false;
        }

        [Button("Move To End")]
        private void MoveToEnd()
        {
            if (_isRecording || _movedToEnd) return;

            _startPosition = _transform.position;

            _transform.position = _position;

            _movedToEnd = true;
            _movedToStart = false;
        }

        [Button("Move To Start")]
        private void MoveToStart()
        {
            if (_isRecording || _movedToStart || _movedToEnd == false) return;

            _transform.position = _startPosition;

            _movedToStart = true;
            _movedToEnd = false;
        }

        private void OnDrawGizmosSelected()
        {
            if (_transform == null) return;

            if (_isRecording)
            {
                DrawRecordingArrow();
            }
            else
            {
                DrawArrow();
            }
        }

        private void DrawRecordingArrow()
        {
            Vector3 targetPosition = _transform.position;
            Vector3 direction = targetPosition - _startPosition;
            
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(_startPosition, 0.1f);
            Extensions.Gizmos.DrawArrow(_startPosition, direction);
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
