using CBA.Animations.Transform.Shake.Core;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Transform.Shake.Rotation
{
    public class RotationShakeAnimation : ShakeAnimationCore
    {
        private Quaternion _startLocalRotation;

        #region MonoBehaviour

        private void Awake()
        {
            _startLocalRotation = _transform.localRotation;
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _transform.DOShakeRotation(_duration, _strengthDirection * _strength, _vibrato, _randomness, _fadeOut, _shakeRandomnessMode);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOShakeRotation(_duration, -_strengthDirection * _strength, _vibrato, _randomness, _fadeOut, _shakeRandomnessMode);

        }

        protected override void MoveToStartState()
        {
            ResetLocalRotation();
        }

        protected override void MoveToEndState()
        {
            ResetLocalRotation();
        }

        private void ResetLocalRotation()
        {
            _transform.localRotation = _startLocalRotation;
        }
        
        #region Editor

#if UNITY_EDITOR

        protected override void DrawShake(UnityEngine.Transform parent)
        {
            Vector3 position = parent.TransformPoint(_transform.localPosition);
            Vector3 direction = _transform.TransformDirection(_strengthDirection * _strength);

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(position, direction);
        }

#endif
        
        #endregion
        
    }
}
