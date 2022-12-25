using CBA.Adapters.Alpha.Core;
using CBA.Extensions;
using NaughtyAttributes;
using UnityEngine;
using Image = UnityEngine.UI.Image;

namespace CBA.Adapters.Alpha
{
    public class AdaptedImageForAlpha : AlphaAdapter
    {
        [Header("References")]
        [Required, SerializeField] private Image _image;
    
        public override float alpha
        {
            get => _image.color.a;
            set => _image.color.WithAlpha(value);
        }
    
        #region MonoBehaviour

        private void OnValidate()
        {
            _image ??= GetComponent<Image>();
        }

        #endregion
    }
}
