using ComponentBasedUI.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Animations.MoveAnimation
{
    public class MoveZAnimation : DirectionMoveAnimation
    {
        protected override Tween CreateTween()
        {
            Tween tween = _transform.DOMoveZ(_to, _duration);

            return tween;
        }

        public override void PlayFromStart()
        {
            MoveToStart();

            _tween.Play();
        }

        private void MoveToStart()
        {
            Vector3 position = _transform.position;
            _transform.position = new Vector3(position.x, position.y, _from);
        }

        #region Editor

#if UNITY_EDITOR

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            _from = _transform.position.z;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            _to = _transform.position.z;
        }

        [Button("Move To Start")]
        private void MoveToStartPositionEditor()
        {
            MoveToStart();
        }

        [Button("Move To End")]
        private void MoveToTargetPosition()
        {
            Vector3 position = _transform.position;

            _transform.position = new Vector3(position.x, position.y, _to);
        }

        private void OnDrawGizmosSelected()
        {
            if (_transform == null) return;

            Vector3 position = _transform.position;

            Vector3 startPosition = new Vector3(position.x, position.y, _from);
            Vector3 targetPosition = new Vector3(position.x, position.y, _to);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.blue;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion

    }
}
