using CBA.Animations.Actions.Core;

namespace CBA.Animations.Actions.Play
{
    public class PlayFromStartImmediate : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromStartImmediate();
        }
    }
}
