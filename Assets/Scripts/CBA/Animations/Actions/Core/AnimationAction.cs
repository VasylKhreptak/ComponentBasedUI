using NaughtyAttributes;
using UnityEngine;
using Animation = CBA.Animations.Core.Animation;

namespace CBA.Animations.Actions.Core
{
    public abstract class AnimationAction : CBA.Actions.Core.Action
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
