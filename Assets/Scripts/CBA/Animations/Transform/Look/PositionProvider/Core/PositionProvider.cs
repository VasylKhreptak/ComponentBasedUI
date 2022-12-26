using UnityEngine;

namespace CBA.Animations.Transform.Look.PositionProvider.Core
{
    public abstract class PositionProvider : MonoBehaviour
    {
        public abstract Vector3 position { get; set; }
    }
}
