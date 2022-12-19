using ComponentBasedUI.Animations.Core;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Serialization;
using Action = ComponentBasedUI.Actions.Core.Action;

namespace ComponentBasedUI.Animations.Actions.Core
{
    public abstract class AnimationAction : Action
    {
        [Header("References")]
        [Required, SerializeField] protected AnimationCore _animation;

        #region MonoBehaviour

        private void OnValidate()
        {
            _animation ??= GetComponent<AnimationCore>();
        }

        #endregion
    }
}
