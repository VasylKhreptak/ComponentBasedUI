using ComponentBasedUI.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationInverted : Action
    {
        [Header("References")]
        [SerializeField] private AnimationCore _animation;

        [Header("Preferences")]
        [SerializeField] private bool _inverted;
        
        public override void Do()
        {
            _animation.GetTween().SetInverted(_inverted);
        }
    }
}