using ComponentBasedUI.MonoEvents.Core;

namespace ComponentBasedUI.Events.Mono
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
