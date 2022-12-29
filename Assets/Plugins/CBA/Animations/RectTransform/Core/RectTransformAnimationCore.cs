using CBA.Animations.Core;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.RectTransform.Core
{
    public abstract class RectTransformAnimationCore : AnimationCore
    {
        [Header("References")]
        [Required, SerializeField] protected UnityEngine.RectTransform _rectTransform;

        #region MonoBehaviour

        private void OnValidate()
        {
            _rectTransform ??= GetComponent<UnityEngine.RectTransform>();
        }

        #endregion
    }
}
