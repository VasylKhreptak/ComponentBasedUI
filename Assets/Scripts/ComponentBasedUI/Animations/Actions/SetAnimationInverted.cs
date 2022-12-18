using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationInverted : AnimationAction
    {
        [Header("Preferences")]
        [SerializeField] private bool _inverted;
        
        public override void Do()
        {
            _animation.GetTween().SetInverted(_inverted);
        }
    }
}
