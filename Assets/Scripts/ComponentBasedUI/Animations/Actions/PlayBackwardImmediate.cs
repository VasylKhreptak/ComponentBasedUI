using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayBackwardImmediate : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayBackwardImmediate();
        }
    }
}
