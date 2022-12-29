using CBA.Animations.Actions.Core;

namespace CBA.Animations.Actions.Play
{
    public class PlayFromEndImmediate : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromEndImmediate();
        }
    }
}
