using ComponentBasedUI.Animations.Listeners;

namespace ComponentBasedUI.Animations.Events
{
    public class OnAnimationUpdate : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.GetTween().onUpdate += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.GetTween().onUpdate -= Invoke;
        }
    }
}
