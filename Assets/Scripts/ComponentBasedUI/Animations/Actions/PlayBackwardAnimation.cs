using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayBackwardAnimation : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayBackward();
        }
    }
}
