using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayFromStartImmediate : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromStartImmediate();
        }
    }
}
