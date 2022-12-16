namespace ComponentBasedUI.MonoEvents
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnStartEvent : MonoEvent
    {
        #region MonoBehaviour

        private void Start()
        {
            Invoke();
        }

        #endregion
    }
}
