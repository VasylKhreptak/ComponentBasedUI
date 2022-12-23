using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayFromEndImmediate : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromEndImmediate();
        }
    }
}
