using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;

namespace ComponentBasedUI.Animations.Actions
{
    public class PauseAnimation : AnimationAction
    {
        public override void Do()
        {
            _animation.GetTween().Pause();
        }
    }
}
