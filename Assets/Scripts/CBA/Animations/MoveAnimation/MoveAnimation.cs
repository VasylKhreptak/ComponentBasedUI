using CBA.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.MoveAnimation
{
    public class MoveAnimation : PositionMoveAnimation
    {
        protected override Tween CreateForwardTween()
        {
            return _transform.DOMove(_targetPosition, _duration);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOMove(_startPosition, _duration);
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

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            _startPosition = _transform.position;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            _targetPosition = _transform.position;
        }

        [Button("Move To Start")]
        private void MoveToStartPositionEditor()
        {
            MoveToStartState();
        }

        [Button("Move To End")]
        private void MoveToTargetPosition()
        {
            MoveToEndState();
        }

        private void OnDrawGizmosSelected()
        {
            if (_transform == null) return;

            Vector3 direction = _targetPosition - _startPosition;

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(_startPosition, direction);
        }

#endif

        #endregion

    }
}
