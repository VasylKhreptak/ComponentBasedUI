using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayFromStart : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromStart();
        }
    }
}
