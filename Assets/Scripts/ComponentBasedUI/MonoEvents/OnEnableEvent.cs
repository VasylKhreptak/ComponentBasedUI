namespace ComponentBasedUI.MonoEvents
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnEnableEvent : MonoEvent
    {
        #region MonoBehaviour

        private void OnEnable()
        {
            Invoke();
        }

        #endregion
    }
}
