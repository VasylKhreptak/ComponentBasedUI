using CBA.Animations.Core;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Actions.Core
{
    public abstract class AnimationAction : CBA.Actions.Core.Action
    {
        [Header("References")]
        [Required, SerializeField] protected AnimationCore _animation;

        #region MonoBehaviour

        private void OnValidate()
        {
            _animation ??= GetComponent<AnimationCore>();
            UnityEngine.Transform parent = transform.parent;
            if (_animation == null && parent != null)
            {
                _animation = parent.GetComponent<AnimationCore>();
            }
        }

        #endregion
    }
}
