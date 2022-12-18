using ComponentBasedUI.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationEase : Action
    {
        [Header("References")]
        [SerializeField] private AnimationCore _animation;

        [Header("Preferences")]
        [SerializeField] private AnimationCurve _curve;

        public override void Do()
        {
            _animation.GetTween().SetEase(_curve);
        }
    }
}
