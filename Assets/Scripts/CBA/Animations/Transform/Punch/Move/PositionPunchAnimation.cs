using CBA.Animations.Transform.Punch.Core;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Transform.Punch.Move
{
    public class PositionPunchAnimation : PunchAnimationCore
    {
        private Vector3 _startLocalPosition;

        #region MonnBehaviour

        private void Awake()
        {
            _startLocalPosition = _transform.localPosition;
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _transform.DOPunchPosition(_punchDirection * _strength, _duration, _vibrato, _elasticity);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOPunchPosition(-_punchDirection * _strength, _duration, _vibrato, _elasticity);
        }

        protected override void MoveToStartState()
        {
            ResetPosition();
        }

        protected override void MoveToEndState()
        {
            ResetPosition();
        }

        private void ResetPosition()
        {
            _transform.localPosition = _startLocalPosition;
        }
    }
}
