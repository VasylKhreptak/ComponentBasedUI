using CBA.Adapters.Alpha.Core;
using CBA.Animations.Core;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Graphics.Fade.Core
{
    public abstract class AlphaAnimationCore : AnimationCore
    {
        [Header("References")]
        [Required, SerializeField] protected AlphaAdapter _alphaAdapter;

        #region MonoBehaviour

        private void OnValidate()
        {
            _alphaAdapter ??= GetComponent<AlphaAdapter>();
        }

        #endregion
    }
}
