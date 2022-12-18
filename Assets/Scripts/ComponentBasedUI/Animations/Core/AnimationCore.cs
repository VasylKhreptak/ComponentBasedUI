public abstract class AnimationCore : UnityEngine.MonoBehaviour
{
    public abstract void Init();

    public abstract DG.Tweening.Tween GetTween();

    public abstract void PlayFromStart();
}
