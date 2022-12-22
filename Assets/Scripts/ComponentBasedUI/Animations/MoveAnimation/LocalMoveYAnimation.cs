using ComponentBasedUI.Animations.MoveAnimation.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Animations.MoveAnimation
{
    public class LocalMoveYAnimation : DirectionMoveAnimation
    {
        protected override Tween CreateTween()
        {
            Tween tween = _transform.DOLocalMoveY(_to, _duration);

            return tween;
        }

        public override void PlayFromStart()
        {
            MoveToStart();

            _tween.Play();
        }

        private void MoveToStart()
        {
            Vector3 localPosition = _transform.localPosition;
            _transform.localPosition = new Vector3(localPosition.x, _from, localPosition.z);
        }

        #region Editor

#if UNITY_EDITOR

        [Button("Assign Start Position")]
        private void AssignStartPositionVariable()
        {
            _from = _transform.localPosition.y;
        }

        [Button("Assign Target Position")]
        private void AssignTargetPosition()
        {
            _to = _transform.localPosition.y;
        }

        [Button("Move To Start")]
        private void MoveToStartPositionEditor()
        {
            MoveToStart();
        }

        [Button("Move To End")]
        private void MoveToTargetPosition()
        {
            Vector3 localPosition = _transform.localPosition;

            _transform.localPosition = new Vector3(localPosition.x, _to, localPosition.z);
        }

        private void OnDrawGizmosSelected()
        {
            Transform parent = _transform.parent;

            if (_transform == null || parent == null) return;

            Vector3 localPosition = _transform.localPosition;

            Vector3 startLocalPosition = new Vector3(localPosition.x, _from, localPosition.z);
            Vector3 targetLocalPosition = new Vector3(localPosition.x, _to, localPosition.z);

            Vector3 startPosition = parent.TransformPoint(startLocalPosition);
            Vector3 targetPosition = parent.TransformPoint(targetLocalPosition);
            Vector3 direction = targetPosition - startPosition;

            Gizmos.color = Color.green;
            Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion

    }
}
