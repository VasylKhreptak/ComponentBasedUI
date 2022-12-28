using CBA.Animations.Transform.Punch.Core;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Transform.Punch.Move
{
    public class PositionPunchAnimation : PunchAnimationCore
    {
        [Header("Snapping")]
        [SerializeField] private bool _snapping;

        private Vector3 _startLocalPosition;

        #region MonoBehaviour

        private void Awake()
        {
            _startLocalPosition = _transform.localPosition;
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _transform.DOPunchPosition(_strengthDirection * _strength, _duration, _vibrato, _elasticity, _snapping);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOPunchPosition(-_strengthDirection * _strength, _duration, _vibrato, _elasticity, _snapping);
        }

        protected override void MoveToStartState()
        {
            ResetLocalPosition();
        }

        protected override void MoveToEndState()
        {
            ResetLocalPosition();
        }

        private void ResetLocalPosition()
        {
            _transform.localPosition = _startLocalPosition;
        }
    }
}
