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
            MoveToStartPosition();

            _tween.Play();
        }

        [Button("Assign Start Position")]
        protected override void AssignStartPositionVariable()
        {
            _startPosition = _transform.localPosition;
        }
        
        [Button("Assign Target Position")]
        protected override void AssignTargetPosition()
        {
            _targetPosition = _transform.localPosition;
        }

        [Button("Move To Start")]
        protected override void MoveToStartPosition()
        {
            _transform.localPosition = _startPosition;
        }
        
        [Button("Move To End")]
        protected override void MoveToTargetPosition()
        {
            _transform.localPosition = _targetPosition;
        }
        
        protected override void DrawGizmosSelected()
        {
            Transform parent = _transform.parent;

            if (parent == null) return;

            Vector3 startPosition = parent.TransformPoint(_startPosition);
            Vector3 targetPosition = parent.TransformPoint(_targetPosition);
            Vector3 direction = targetPosition - startPosition;

            UnityEngine.Gizmos.color = Color.white;
            Gizmos.DrawArrow(startPosition, direction);
        }
    }
}
