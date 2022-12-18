using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;
using UnityEngine;

namespace ComponentBasedUI.Animations.Actions
{
    public class SetAnimationLoopType : AnimationAction
    {
        [Header("Preferences")]
        [SerializeField] private LoopType _loopType;

        public override void Do()
        {
            Tween tween = _animation.GetTween();

            tween.SetLoops(tween.Loops(), _loopType);
        }
    }
}
