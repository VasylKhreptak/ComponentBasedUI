using ComponentBasedUI.Adapters.Core;
using ComponentBasedUI.Extensions;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Adapters.Alpha
{
    public class AdaptedSpriteRendererForAlpha : FloatAdapter
    {
        [Header("References")]
        [Required, SerializeField] private SpriteRenderer _spriteRenderer;
    
        public override float value
        {
            get => _spriteRenderer.color.a;
            set => _spriteRenderer.color.WithAlpha(value);
        }
    
        #region MonoBehaviour

        private void OnValidate()
        {
            _spriteRenderer ??= GetComponent<SpriteRenderer>();
        }

        #endregion
    }
}
