using CBA.Animations.Actions.Core;

namespace CBA.Animations.Actions.Play
{
    public class PlayFromEnd : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromEnd();
        }
    }
}
