using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationEase : AnimationAction
    {
        [Header("Preferences")]
        [SerializeField] private AnimationCurve _curve;

        public override void Do()
        {
            _animation.GetTween().SetEase(_curve);
        }
    }
}
