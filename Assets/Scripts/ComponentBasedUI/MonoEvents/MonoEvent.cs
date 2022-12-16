namespace ComponentBasedUI.MonoEvents
{
    public class MonoEvent : UnityEngine.MonoBehaviour
    {
        public System.Action onMonoCall;

        protected virtual void Invoke() => onMonoCall?.Invoke();
    }
}
