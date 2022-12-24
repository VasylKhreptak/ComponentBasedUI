using CBA.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.MoveAnimation
{
    public class LocalMoveZAnimation : DirectionMoveAnimation
    {
        protected override Tween CreateForwardTween()
        {
            return _transform.DOLocalMoveZ(_to, _duration);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOLocalMoveZ(_from, _duration);
        }

        protected override void MoveTo(float axisPosition)
        {
            Vector3 localPosition = _transform.localPosition;
            _transform.localPosition = new Vector3(localPosition.x, localPosition.y, axisPosition);
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            if (_isRecording) return;

            _from = _transform.localPosition.z;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            if (_isRecording) return;

            _to = _transform.localPosition.z;
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
            _from = _transform.localPosition.z;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _to = _transform.localPosition.z;
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
            Vector3 localPosition = _transform.localPosition;
            Vector3 startLocalPosition = new Vector3(localPosition.x, localPosition.y, _from);
            Vector3 targetLocalPosition = new Vector3(localPosition.x, localPosition.y, _to);
            Vector3 startPosition = parent.TransformPoint(startLocalPosition);
            Vector3 targetPosition = parent.TransformPoint(targetLocalPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.blue;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

        private void DrawRecordingArrow(Transform parent)
        {
            Vector3 localPosition = _transform.localPosition;
            Vector3 startLocalPosition = new Vector3(localPosition.x, localPosition.y, _from);
            Vector3 targetLocalPosition = new Vector3(startLocalPosition.x, startLocalPosition.y, localPosition.z);
            Vector3 startPosition = parent.TransformPoint(startLocalPosition);
            Vector3 targetPosition = parent.TransformPoint(targetLocalPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.red;
            Gizmos.DrawSphere(startPosition, 0.1f);
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion

    }
}
