using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Animations.Core
{
    public abstract class Animation : MonoBehaviour
    {
        [Header("Duration")]
        [SerializeField] protected float _duration;

        [Header("Animation Preferences")]
        [SerializeField] private int _id = -999;
        [SerializeField] private float _delay;
        [SerializeField] private int _loops = 1;
        [SerializeField] private LoopType _loopType = DOTween.defaultLoopType;
        [SerializeField] private bool useAnimationCurve;
        [HideIf(nameof(useAnimationCurve)), SerializeField] private Ease _ease = DOTween.defaultEaseType;
        [ShowIf(nameof(useAnimationCurve)), SerializeField] private AnimationCurve _curve;
        [SerializeField] private UpdateType _updateType = DOTween.defaultUpdateType;

        private Tween _tween;

        public Tween Tween => _tween;

        #region MonoBehaviour

        protected virtual void OnDestroy()
        {
            _tween.Kill();
        }

        #endregion

        protected abstract Tween CreateForwardTween();

        protected abstract Tween CreateBackwardTween();

        protected abstract void MoveToStartState();

        protected abstract void MoveToEndState();

        private void ApplyAnimationPreferences()
        {
            _tween.SetId(_id);
            _tween.SetDelay(_delay);
            _tween.SetLoops(_loops, _loopType);
            _tween.SetUpdate(_updateType);
            _tween.SetAutoKill(true);

            if (useAnimationCurve)
            {
                _tween.SetEase(_curve);
            }
            else
            {
                _tween.SetEase(_ease);
            }
        }

        public void PlayForward()
        {
            if (_tween == null || _tween.active == false)
            {
                _tween = CreateForwardTween();
                ApplyAnimationPreferences();
                _tween.Play();
            }
        }

        public void PlayBackward()
        {
            if (_tween == null || _tween.active == false)
            {
                _tween = CreateBackwardTween();
                ApplyAnimationPreferences();
                _tween.Play();
            }
        }

        public void PlayFromStart()
        {
            if (_tween == null || _tween.active == false)
            {
                _tween = CreateForwardTween();
                ApplyAnimationPreferences();
                MoveToStartState();
                _tween.Play();
            }
        }

        public void PlayFromEnd()
        {
            if (_tween == null || _tween.active == false)
            {
                _tween = CreateBackwardTween();
                ApplyAnimationPreferences();
                MoveToEndState();
                _tween.Play();
            }
        }

        public void PlayFromStartImmediate()
        {
            _tween.Kill();
            _tween = CreateForwardTween();
            ApplyAnimationPreferences();
            MoveToStartState();
            _tween.Play();
        }

        public void PlayFromEndImmediate()
        {
            _tween.Kill();
            _tween = CreateBackwardTween();
            ApplyAnimationPreferences();
            MoveToEndState();
            _tween.Play();
        }
    }
}
