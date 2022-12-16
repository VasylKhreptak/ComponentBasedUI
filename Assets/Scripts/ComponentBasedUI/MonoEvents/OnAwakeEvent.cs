namespace ComponentBasedUI.MonoEvents
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnAwakeEvent : MonoEvent
    {
        #region MonoBehaviour

        private void Awake()
        {
            Invoke();
        }

        #endregion
    }
}
