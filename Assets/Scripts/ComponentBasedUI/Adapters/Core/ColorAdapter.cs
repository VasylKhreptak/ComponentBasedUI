using UnityEngine;

namespace ComponentBasedUI.Adapters.Core
{
    public abstract class ColorAdapter : MonoBehaviour
    {
        public abstract UnityEngine.Color color { get; set; }
    }
}
