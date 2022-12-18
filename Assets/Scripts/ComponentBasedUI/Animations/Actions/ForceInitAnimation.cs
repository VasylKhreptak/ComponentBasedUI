using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;

namespace ComponentBasedUI.Animations.Actions
{
    public class ForceInitAnimation : AnimationAction
    {
        public override void Do()
        {
            _animation.GetTween().ForceInit();
        }
    }
}
