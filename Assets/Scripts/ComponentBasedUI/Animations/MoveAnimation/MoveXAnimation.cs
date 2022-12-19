using ComponentBasedUI.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Animations.MoveAnimation
{
    public class MoveXAnimation : DirectionMoveAnimation
    {
        protected override Tween CreateTween()
        {
            Tween tween = _transform.DOMoveX(_to, _duration);

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
            _from = _transform.position.x;
        }

        [Button("Assign Target Position")]
        protected override void AssignTargetPosition()
        {
            _to = _transform.position.x;
        }

        [Button("Move To Start")]
        protected override void MoveToStartPosition()
        {
            Vector3 position = _transform.position;

            _transform.position = new Vector3(_from, position.y, position.z);
        }

        [Button("Move To End")]
        protected override void MoveToTargetPosition()
        {
            Vector3 position = _transform.position;

            _transform.position = new Vector3(_to, position.y, position.z);
        }

        protected override void DrawGizmosSelected()
        {
            Vector3 position = _transform.position;

            Vector3 startPosition = new Vector3(_from, position.y, position.z);
            Vector3 targetPosition = new Vector3(_to, position.y, position.z);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.red;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }
    }
}
