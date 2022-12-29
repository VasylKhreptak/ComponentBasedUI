using CBA.Animations.Actions.Core;

namespace CBA.Animations.Actions.Play
{
    public class PlayFromStart : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayFromStart();
        }
    }
}
