using CBA.Animations.Transform.Punch.Core;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Transform.Punch.Scale
{
    public class ScalePunchAnimation : PunchAnimationCore
    {
        private Vector3 _startLocalScale;

        #region MonnBehaviour

        private void Awake()
        {
            _startLocalScale = _transform.localScale;
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return _transform.DOPunchScale(_punchDirection * _strength, _duration, _vibrato, _elasticity);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DOPunchScale(-_punchDirection * _strength, _duration, _vibrato, _elasticity);
        }

        protected override void MoveToStartState()
        {
            ResetScale();
        }

        protected override void MoveToEndState()
        {
            ResetScale();
        }

        private void ResetScale()
        {
            _transform.localScale = _startLocalScale;
        }
        
        #region Editor

#if UNITY_EDITOR

        protected override void DrawPunch(UnityEngine.Transform parent)
        {
            Vector3 position = parent.TransformPoint(_transform.localPosition);
            Vector3 direction = _transform.TransformDirection(_punchDirection * _strength);

            Gizmos.color = Color.white;
            Extensions.Gizmos.DrawArrow(position, direction);
        }

#endif
        
        #endregion
        
    }
}
