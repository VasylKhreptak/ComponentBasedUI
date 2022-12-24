using CBA.Animations.Listeners;

namespace CBA.Animations.Events
{
    public class OnAnimationPause : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.Tween.onPause += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.Tween.onPause -= Invoke;
        }
    }
}
