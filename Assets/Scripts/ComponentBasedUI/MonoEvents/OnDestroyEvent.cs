namespace ComponentBasedUI.MonoEvents
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnDestroyEvent : MonoEvent
    {
        #region MonoBehaviour

        private void OnDestroy()
        {
            Invoke();
        }

        #endregion
    }
}
