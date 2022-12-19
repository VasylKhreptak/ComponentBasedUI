using ComponentBasedUI.Adapters.Core;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

namespace ComponentBasedUI.Adapters.Color
{
    public class AdaptedImageForColor : ColorAdapter
    {
        [Header("References")]
        [Required, SerializeField] private Image _image;
    
        public override UnityEngine.Color color
        {
            get => _image.color;
            set => _image.color = value;
        }
    
        #region MonoBehaviour

        private void OnValidate()
        {
            _image ??= GetComponent<Image>();
        }

        #endregion
    }
}
