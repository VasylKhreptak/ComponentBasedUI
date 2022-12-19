using DG.Tweening;

namespace ComponentBasedUI.Animations.Core
{
    public abstract class Animation : AnimationCore
    {
        protected Tween _tween;

        #region MonoBehaviour

        protected virtual void OnDestroy()
        {
            _tween.Kill();
        }

        #endregion

        public override Tween GetTween()
        {
            return _tween;
        }

        protected abstract Tween CreateTween();

        public override void Init()
        {
            _tween = CreateTween();
            
            onInit?.Invoke();
        }
    }
}
