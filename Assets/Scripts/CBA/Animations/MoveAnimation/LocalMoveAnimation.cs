using CBA.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.MoveAnimation
{
    public class LocalMoveAnimation : PositionMoveAnimation
    {
        protected override Tween CreateForwardTween()
        {
            return _transform.DOLocalMove(_targetPosition, _duration);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOLocalMove(_startPosition, _duration);
        }

        protected override void MoveToStartState()
        {
            _transform.localPosition = _startPosition;
        }

        protected override void MoveToEndState()
        {
            _transform.localPosition = _targetPosition;
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            if (_isRecording) return;

            _startPosition = _transform.localPosition;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            if (_isRecording) return;

            _targetPosition = _transform.localPosition;
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
            _startPosition = _transform.localPosition;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _targetPosition = _transform.localPosition;
            MoveToStartState();

            _isRecording = false;
        }

        private void OnDrawGizmosSelected()
        {
            Transform parent = _transform.parent;

            if (_transform == null || parent == null) return;

            if (_isRecording)
            {
                DrawRecordingArrow(parent);
            }
            else
            {
                DrawDefaultArrow(parent);
            }
        }

        private void DrawDefaultArrow(Transform parent)
        {
            Vector3 startPosition = parent.TransformPoint(_startPosition);
            Vector3 targetPosition = parent.TransformPoint(_targetPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

        private void DrawRecordingArrow(Transform parent)
        {
            Vector3 startPosition = parent.TransformPoint(_startPosition);
            Vector3 direction = _transform.position - startPosition;

            Gizmos.color = Color.red;
            Gizmos.DrawSphere(startPosition, 0.1f);
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion

    }
}