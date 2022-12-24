using CBA.Animations.Listeners;

namespace CBA.Animations.Events
{
    public class OnAnimationPlay : AnimationEventListener
    {
        protected override void AddListener()
        {
            _animation.Tween.onPlay += Invoke;
        }
        protected override void RemoveListener()
        {
            _animation.Tween.onPlay -= Invoke;
        }
    }
}
