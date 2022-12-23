using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayForwardAnimation : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayForward();
        }
    }
}
