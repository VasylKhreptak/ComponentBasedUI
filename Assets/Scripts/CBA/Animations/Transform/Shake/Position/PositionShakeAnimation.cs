using CBA.Animations.Transform.Shake.Core;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Transform.Shake.Position
{
    public class PositionShakeAnimation : ShakeAnimationCore
    {
        private Vector3 _startLocalPosition;

        #region MonoBehaviour

        private void Awake()
        {
            _startLocalPosition = _transform.localPosition;
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _transform.DOShakePosition(_duration, _strengthDirection * _strength, _vibrato, _randomness, fadeOut: _fadeOut, randomnessMode: _shakeRandomnessMode);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOShakePosition(_duration, -_strengthDirection * _strength, _vibrato, _randomness, fadeOut: _fadeOut, randomnessMode: _shakeRandomnessMode);

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
