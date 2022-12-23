using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class PlayForwardImmediate : AnimationAction
    {
        public override void Do()
        {
            _animation.PlayForwardImmediate();
        }
    }
}
