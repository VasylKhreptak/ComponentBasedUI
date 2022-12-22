using NaughtyAttributes;
using UnityEngine;
using Animation = ComponentBasedUI.Animations.Core.Animation;

namespace ComponentBasedUI.Animations.MoveAnimation.Core
{
    public abstract class MoveAnimationCore : Animation
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
