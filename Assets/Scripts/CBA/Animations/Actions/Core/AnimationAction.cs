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
            UnityEngine.Transform parent = transform.parent;
            if (_animation == null && parent != null)
            {
                _animation = parent.GetComponent<Animation>();
            }
        }

        #endregion
    }
}
