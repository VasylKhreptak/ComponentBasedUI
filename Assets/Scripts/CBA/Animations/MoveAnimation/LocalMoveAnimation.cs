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

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            _startPosition = _transform.localPosition;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            _targetPosition = _transform.localPosition;
        }

        [Button("Move To Start")]
        private void MoveToStartPositionEditor()
        {
            MoveToStartState();
        }

        [Button("Move To End")]
        private void MoveToTargetPosition()
        {
            _transform.localPosition = _targetPosition;
        }

        private void OnDrawGizmosSelected()
        {
            Transform parent = _transform.parent;

            if (_transform == null || parent == null) return;

            Vector3 startPosition = parent.TransformPoint(_startPosition);
            Vector3 targetPosition = parent.TransformPoint(_targetPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion

    }
}
