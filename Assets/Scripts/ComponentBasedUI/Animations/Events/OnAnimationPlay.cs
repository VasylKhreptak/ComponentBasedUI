using ComponentBasedUI.Animations.Listeners;

namespace ComponentBasedUI.Animations.Events
{
    public class OnAnimationPlay : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.GetTween().onPlay += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.GetTween().onPlay -= Invoke;
        }
    }
}
