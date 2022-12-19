using ComponentBasedUI.Animations.Listeners;

namespace ComponentBasedUI.Animations.Events
{
    public class OnAnimationStepComplete : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.GetTween().onStepComplete += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.GetTween().onStepComplete -= Invoke;
        }
    }
}
