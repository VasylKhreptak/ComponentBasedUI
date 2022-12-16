namespace ComponentBasedUI.Sequences
{
    public abstract class Sequence : UnityEngine.MonoBehaviour
    {
        public abstract DG.Tweening.Sequence GetSequence();
    }
}
