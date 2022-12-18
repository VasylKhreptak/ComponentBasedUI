using ComponentBasedUI.MonoEvents.Core;

namespace ComponentBasedUI.Events.Mono
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