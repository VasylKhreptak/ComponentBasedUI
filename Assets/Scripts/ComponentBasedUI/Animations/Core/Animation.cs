using DG.Tweening;

namespace ComponentBasedUI.Animations.Core
{
    public class Animation : AnimationCore
    {
        protected Tween _tween;
        
        #region MonoBehaviour

        private void OnDestroy()
        {
            _tween.Kill();
        }

        #endregion

        public override Tween GetTween()
        {
            return _tween;
        }

    }
}
