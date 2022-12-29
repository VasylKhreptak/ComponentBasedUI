using CBA.Animations.Transform.Punch.Core;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Transform.Punch.Rotation
{
    public class RotationPunchAnimation : PunchAnimationCore
    {
        private Quaternion _startLocalRotation;

        #region MonnBehaviour

        private void Awake()
        {
            _startLocalRotation = _transform.rotation;
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _transform.DOPunchRotation(_strengthDirection * _strength, _duration, _vibrato, _elasticity);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOPunchRotation(-_strengthDirection * _strength, _duration, _vibrato, _elasticity);
        }

        protected override void MoveToStartState()
        {
            ResetRotation();
        }

        protected override void MoveToEndState()
        {
            ResetRotation();
        }

        private void ResetRotation()
        {
            _transform.localRotation = _startLocalRotation;
        }

        #region Editor

#if UNITY_EDITOR

        protected override void DrawPunch(UnityEngine.Transform parent)
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
