using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayFromEnd : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromEnd();
        }
    }
}
