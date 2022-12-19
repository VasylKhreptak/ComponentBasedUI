using ComponentBasedUI.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Animations.MoveAnimation
{
    public class LocalMoveZAnimation : DirectionMoveAnimation
    {
        protected override Tween CreateTween()
        {
            Tween tween = _transform.DOLocalMoveZ(_to, _duration);

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
            _from = _transform.localPosition.z;
        }

        [Button("Assign Target Position")]
        protected override void AssignTargetPosition()
        {
            _to = _transform.localPosition.z;
        }

        [Button("Move To Start")]
        protected override void MoveToStartPosition()
        {
            Vector3 localPosition = _transform.localPosition;

            _transform.localPosition = new Vector3(localPosition.x, localPosition.y, _from);
        }

        [Button("Move To End")]
        protected override void MoveToTargetPosition()
        {
            Vector3 localPosition = _transform.localPosition;

            _transform.localPosition = new Vector3(localPosition.x, localPosition.y, _to);
        }

        protected override void DrawGizmosSelected()
        {
            Transform parent = _transform.parent;

            if (parent == null) return;

            Vector3 localPosition = _transform.localPosition;

            Vector3 startLocalPosition = new Vector3(localPosition.x, localPosition.y, _from);
            Vector3 targetLocalPosition = new Vector3(localPosition.x, localPosition.y, _to);

            Vector3 startPosition = parent.TransformPoint(startLocalPosition);
            Vector3 targetPosition = parent.TransformPoint(targetLocalPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.blue;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }
    }
}
