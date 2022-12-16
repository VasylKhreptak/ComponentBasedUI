namespace ComponentBasedUI.Animations.Core
{
    public abstract class Animation : UnityEngine.MonoBehaviour
    {
        public abstract DG.Tweening.Tween GetTween();
    }
}
