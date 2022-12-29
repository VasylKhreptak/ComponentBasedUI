using CBA.Animations.Listeners;

namespace CBA.Animations.Events
{
    public class OnAnimationComplete : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.Tween.onComplete += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.Tween.onComplete -= Invoke;
        }
    }
}
