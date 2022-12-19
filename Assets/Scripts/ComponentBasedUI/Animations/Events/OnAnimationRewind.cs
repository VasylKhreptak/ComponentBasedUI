using ComponentBasedUI.Animations.Listeners;

namespace ComponentBasedUI.Animations.Events
{
    public class OnAnimationRewind : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.GetTween().onRewind += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.GetTween().onRewind -= Invoke;
        }
    }
}
