using CBA.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.MoveAnimation
{
    public class MoveXAnimation : DirectionMoveAnimation
    {
        protected override Tween CreateForwardTween()
        {
            return _transform.DOMoveX(_to, _duration);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOMoveX(_from, _duration);
        }

        protected override void MoveTo(float axisPosition)
        {
            Vector3 position = _transform.position;
            _transform.position = new Vector3(axisPosition, position.y, position.z);
        }

        #region Editor

#if UNITY_EDITOR

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            _from = _transform.position.x;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            _to = _transform.position.x;
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

            Vector3 position = _transform.position;

            Vector3 startPosition = new Vector3(_from, position.y, position.z);
            Vector3 targetPosition = new Vector3(_to, position.y, position.z);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.red;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion

    }
}
