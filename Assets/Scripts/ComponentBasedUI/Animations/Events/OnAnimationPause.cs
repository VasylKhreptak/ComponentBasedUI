using ComponentBasedUI.Animations.Listeners;

namespace ComponentBasedUI.Animations.Events
{
    public class OnAnimationPause : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.GetTween().onPause += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.GetTween().onPause -= Invoke;
        }
    }
}
