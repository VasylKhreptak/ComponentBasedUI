using CBA.Animations.Transform.Move.Jump.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Transform.Move.Jump
{
    public class JumpAnimation : JumpAnimationCore
    {
        protected override Tween CreateForwardTween()
        {
            return _transform.DOJump(_targetPosition, _power, _jumpsNumber, _duration);
        }
        protected override Tween CreateBackwardTween()
        {
            return _transform.DOJump(_startPosition, _power, _jumpsNumber, _duration);
        }
        protected override void MoveToStartState()
        {
            _transform.position = _startPosition;
        }
        protected override void MoveToEndState()
        {
            _transform.position = _targetPosition;
        }
        
        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            if (_isRecording) return;

            _startPosition = _transform.position;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            if (_isRecording) return;

            _targetPosition = _transform.position;
        }

        [Button("Move To Start")]
        private void MoveToStartPositionEditor()
        {
            if (_isRecording) return;

            MoveToStartState();
        }

        [Button("Move To End")]
        private void MoveToTargetPosition()
        {
            if (_isRecording) return;

            MoveToEndState();
        }

        [Button("Start Recording")]
        private void StartRecording()
        {
            _startPosition = _transform.position;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _targetPosition = _transform.position;
            MoveToStartState();

            _isRecording = false;
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
                DrawDefaultArrow();
            }
        }

        private void DrawDefaultArrow()
        {
            Vector3 direction = _targetPosition - _startPosition;

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(_startPosition, direction);
        }

        private void DrawRecordingArrow()
        {
            Vector3 direction = _transform.position - _startPosition;

            Gizmos.color = Color.red;
            Gizmos.DrawSphere(_startPosition, 0.1f);
            Extensions.Gizmos.DrawArrow(_startPosition, direction);
        }

#endif

        #endregion
        
    }
}
