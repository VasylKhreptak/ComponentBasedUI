using CBA.Animations.Transform.Look.Core;
using DG.Tweening;

namespace CBA.Animations.Transform.Look
{
    public class DynamicLookAtAnimation : LookAtAnimation
    {
        protected override Tween CreateForwardTween()
        {
            return _transform.DODynamicLookAt(_endTarget.position, _duration, _axisConstraint, _up);
        }

        protected override Tween CreateBackwardTween()
        {
            return _transform.DODynamicLookAt(_starTarget.position, _duration, _axisConstraint, _up);
        }
    }
}
