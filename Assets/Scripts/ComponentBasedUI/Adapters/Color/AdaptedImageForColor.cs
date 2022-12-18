using ComponentBasedUI.Adapters.Core;
using UnityEngine;
using UnityEngine.UI;

public class AdaptedImageForColor : ColorAdapter
{
    [Header("References")]
    [SerializeField] private Image _image;
    
    public override Color color
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
