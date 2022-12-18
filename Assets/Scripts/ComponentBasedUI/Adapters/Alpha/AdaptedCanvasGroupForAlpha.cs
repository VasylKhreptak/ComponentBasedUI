using ComponentBasedUI.Adapters.Core;
using UnityEngine;

namespace ComponentBasedUI.Adapters.Alpha
{
    public class AdaptedCanvasGroupForColor : FloatAdapter
    {
        [Header("References")]
        [SerializeField] private CanvasGroup _canvasGroup;
    
        public override float value
        {
            get => _canvasGroup.alpha;
            set => _canvasGroup.alpha = value;
        }
    
        #region MonoBehaviour

        private void OnValidate()
        {
            _canvasGroup ??= GetComponent<CanvasGroup>();
        }

        #endregion
    }
}
