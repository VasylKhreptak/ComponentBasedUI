using ComponentBasedUI.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Animations.MoveAnimation
{
    public class MoveAnimation : PositionMoveAnimationCore
    {
        protected override Tween CreateTween()
        {
            Tween tween = _transform.DOMove(_targetPosition, _duration);

            return tween;
        }

        public override void PlayFromStart()
        {
            MoveToStart();

            _tween.Play();
        }

        private void MoveToStart()
        {
            _transform.position = _startPosition;
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
            MoveToStart();
        }

        [Button("Move To End")]
        private void MoveToTargetPosition()
        {
            _transform.position = _targetPosition;
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
