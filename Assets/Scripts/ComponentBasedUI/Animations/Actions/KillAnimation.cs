using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;

namespace ComponentBasedUI.Animations.Actions
{
    public class KillAnimation : AnimationAction
    {
        public override void Do()
        {
            _animation.GetTween().Kill();
        }
    }
}
