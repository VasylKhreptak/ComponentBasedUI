using ComponentBasedUI.Events.Core;

namespace ComponentBasedUI.Events.Mono
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
