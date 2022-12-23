using NaughtyAttributes;
using UnityEngine;
using Action = ComponentBasedUI.Actions.Core.Action;
using Animation = ComponentBasedUI.Animations.Core.Animation;

namespace ComponentBasedUI.Animations.Actions.Core
{
    public abstract class AnimationAction : Action
    {
        [Header("References")]
        [Required, SerializeField] protected Animation _animation;

        #region MonoBehaviour

        private void OnValidate()
        {
            _animation ??= GetComponent<Animation>();
        }

        #endregion
    }
}
