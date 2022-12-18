using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;

namespace ComponentBasedUI.Animations.Actions
{
    public class TogglePauseAnimation : AnimationAction
    {
        public override void Do()
        {
            _animation.GetTween().TogglePause();
        }
    }
}
