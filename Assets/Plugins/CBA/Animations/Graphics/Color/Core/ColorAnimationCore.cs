using CBA.Adapters.Color.Core;
using CBA.Animations.Core;
using UnityEngine;

namespace CBA.Animations.Graphics.Color.Core
{
    public abstract class ColorAnimationCore : AnimationCore
    {
        [Header("References")]
        [SerializeField] protected ColorAdapter _colorAdapter;

        #region Monobehavioue

        private void OnValidate()
        {
            _colorAdapter ??= GetComponent<ColorAdapter>();
        }

        #endregion
    }
}
