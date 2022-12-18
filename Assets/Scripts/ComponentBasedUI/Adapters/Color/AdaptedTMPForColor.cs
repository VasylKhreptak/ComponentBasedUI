using ComponentBasedUI.Adapters.Core;
using TMPro;
using UnityEngine;

public class AdaptedTMPForColor : ColorAdapter
{
    [Header("References")]
    [SerializeField] private TMP_Text _tmpText;
    
    public override Color color
    {
        get => _tmpText.color;
        set => _tmpText.color = value;
    }
    
    #region MonoBehaviour

    private void OnValidate()
    {
        _tmpText ??= GetComponent<TMP_Text>();
    }

    #endregion
}
