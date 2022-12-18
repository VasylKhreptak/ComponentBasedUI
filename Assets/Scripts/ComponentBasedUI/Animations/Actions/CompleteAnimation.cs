using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;

namespace ComponentBasedUI.Animations.Actions
{
    public class CompleteAnimation : AnimationAction
    {
        public override void Do()
        {
            _animation.GetTween().Complete();
        }
    }
}
