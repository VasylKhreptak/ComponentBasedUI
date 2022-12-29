using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Transform.Core
{
    public abstract class TransformAnimationCore : Animations.Core.AnimationCore
    {
        [Header("References")]
        [Required, SerializeField] protected UnityEngine.Transform _transform;

        #region MonoBehaviour

        private void OnValidate()
        {
            _transform ??= GetComponent<UnityEngine.Transform>();
        }

        #endregion
    }
}
