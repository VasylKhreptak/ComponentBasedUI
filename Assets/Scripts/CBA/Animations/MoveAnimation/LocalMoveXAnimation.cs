using CBA.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.MoveAnimation
{
    public class LocalMoveXAnimation : DirectionMoveAnimation
    {
        protected override Tween CreateForwardTween()
        {
            return _transform.DOLocalMoveX(_to, _duration);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOLocalMoveX(_from, _duration);
        }
        
        protected override void MoveTo(float axisPosition)
        {
            Vector3 localPosition = _transform.localPosition;
            _transform.localPosition = new Vector3(axisPosition, localPosition.y, localPosition.z);
        }

        #region Editor

#if UNITY_EDITOR

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            _from = _transform.localPosition.x;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            _to = _transform.localPosition.x;
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
            Transform parent = _transform.parent;

            if (_transform == null || parent == null) return;

            Vector3 localPosition = _transform.localPosition;

            Vector3 startLocalPosition = new Vector3(_from, localPosition.y, localPosition.z);
            Vector3 targetLocalPosition = new Vector3(_to, localPosition.y, localPosition.z);

            Vector3 startPosition = parent.TransformPoint(startLocalPosition);
            Vector3 targetPosition = parent.TransformPoint(targetLocalPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.red;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion

    }
}
