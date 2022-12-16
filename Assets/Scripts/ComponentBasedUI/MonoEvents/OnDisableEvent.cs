namespace ComponentBasedUI.MonoEvents
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnDisableEvent : MonoEvent
    {
        #region MonoBehaviour

        private void OnDisable()
        {
            Invoke();
        }

        #endregion
    }
}
