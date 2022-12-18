using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayAnimationFromStart : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromStart();
        }
    }
}
