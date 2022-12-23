using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.MoveAnimation.Core
{
    public abstract class TransformAnimation : Animations.Core.Animation
    {
        [Header("References")]
        [Required, SerializeField] protected Transform _transform;

        #region MonoBehaviour

        private void OnValidate()
        {
            _transform ??= GetComponent<Transform>();
        }

        #endregion
    }
}
