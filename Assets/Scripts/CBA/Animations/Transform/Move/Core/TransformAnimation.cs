using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Transform.Move.Core
{
    public abstract class TransformAnimation : Animations.Core.Animation
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
