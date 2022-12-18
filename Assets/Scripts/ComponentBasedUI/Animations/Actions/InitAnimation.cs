using ComponentBasedUI.Animations.Actions.Core;
using DG.Tweening;

public class InitAnimation : AnimationAction
{
    public override void Do()
    {
        _animation.GetTween().Kill();
        _animation.Init();
    }
}
