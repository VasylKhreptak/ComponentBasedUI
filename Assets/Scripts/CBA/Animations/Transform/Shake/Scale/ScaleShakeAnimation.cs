using CBA.Animations.Transform.Shake.Core;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Transform.Shake.Scale
{
    public class ScaleShakeAnimation : ShakeAnimationCore
    {
        private Vector3 _startLocalScale;

        #region MonoBehaviour

        private void Awake()
        {
            _startLocalScale = _transform.localScale;
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _transform.DOShakeScale(_duration, _strengthDirection * _strength, _vibrato, _randomness, _fadeOut, _shakeRandomnessMode);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOShakeScale(_duration, -_strengthDirection * _strength, _vibrato, _randomness, _fadeOut, _shakeRandomnessMode);

        }

        protected override void MoveToStartState()
        {
            ResetLocalScale();
        }

        protected override void MoveToEndState()
        {
            ResetLocalScale();
        }

        private void ResetLocalScale()
        {
            _transform.localScale = _startLocalScale;
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
