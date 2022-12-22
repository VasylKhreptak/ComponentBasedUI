using ComponentBasedUI.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;
using Gizmos = ComponentBasedUI.Extensions.Gizmos;

namespace ComponentBasedUI.Animations.MoveAnimation
{
    public class LocalMoveAnimation : PositionMoveAnimationCore
    {
        protected override Tween CreateTween()
        {
            Tween tween = _transform.DOLocalMove(_targetPosition, _duration);

            return tween;
        }

        public override void PlayFromStart()
        {
            MoveToStart();

            _tween.Play();
        }

        private void MoveToStart()
        {
            _transform.localPosition = _startPosition;
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
            MoveToStart();
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

            UnityEngine.Gizmos.color = Color.white;
            Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion

    }
}
