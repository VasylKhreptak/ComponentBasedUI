using ComponentBasedUI.Animations.Listeners;

namespace ComponentBasedUI.Animations.Events
{
    public class OnAnimationComplete : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.GetTween().onComplete += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.GetTween().onComplete -= Invoke;
        }
    }
}
