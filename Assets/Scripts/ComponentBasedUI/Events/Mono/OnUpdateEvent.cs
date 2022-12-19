using ComponentBasedUI.Events.Core;

namespace ComponentBasedUI.Events.Mono
{
    [UnityEngine.DisallowMultipleComponent]
    public class OnUpdateEvent : MonoEvent
    {
        #region MonoBehaviour

        private void Update()
        {
            Invoke();
        }

        #endregion
    }
}
