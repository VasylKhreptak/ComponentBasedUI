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
            _transform.position = _startPosition;

            _tween.Play();
        }

        [Button("Assign Start Position")]
        protected override void AssignStartPositionVariable()
        {
            _startPosition = _transform.position;
        }

        [Button("Assign Target Position")]
        protected override void AssignTargetPosition()
        {
            _targetPosition = _transform.position;
        }

        [Button("Move To Start")]
        protected override void MoveToStartPosition()
        {
            _transform.position = _startPosition;
        }

        [Button("Move To End")]
        protected override void MoveToTargetPosition()
        {
            _transform.position = _targetPosition;
        }

        protected override void DrawGizmosSelected()
        {
            Vector3 direction = _targetPosition - _startPosition;

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(_startPosition, direction);
        }
    }
}
