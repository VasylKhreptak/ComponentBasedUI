using CBA.Animations.Listeners;

namespace CBA.Animations.Events
{
    public class OnAnimationUpdate : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.Tween.onUpdate += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.Tween.onUpdate -= Invoke;
        }
    }
}
