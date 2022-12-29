using CBA.Animations.Actions.Core;
using DG.Tweening;

namespace CBA.Animations.Actions
{
    public class KillAnimation : AnimationAction
    {
        public override void Do()
        {
            _animation.Tween.Kill();
        }
    }
}