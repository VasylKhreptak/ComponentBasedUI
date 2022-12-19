using ComponentBasedUI.Animations.Listeners;

namespace ComponentBasedUI.Animations.Events
{
    public class OnAnimationKill : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.GetTween().onKill += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.GetTween().onKill -= Invoke;
        }
    }
}
