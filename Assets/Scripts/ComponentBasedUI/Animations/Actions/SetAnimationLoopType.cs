using ComponentBasedUI.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationLoopType : Action
    {
        [Header("References")]
        [SerializeField] private AnimationCore _animation;

        [Header("Preferences")]
        [SerializeField] private LoopType _loopType;

        public override void Do()
        {
            Tween tween = _animation.GetTween();

            tween.SetLoops(tween.Loops(), _loopType);
        }
    }
}
