using CBA.Animations.Actions.Core;

namespace CBA.Animations.Actions.Play
{
    public class PlayBackwardImmediate : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayBackwardImmediate();
        }
    }
}
