using System;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Core
{
    public abstract class AnimationCore : MonoBehaviour
    {
        [Header("Duration")]
        [SerializeField] protected float _duration = 1f;

        [Header("Animation Preferences")]
        [SerializeField] private bool _useAnimationCurve;
        [HideIf(nameof(_useAnimationCurve)), SerializeField] private Ease _ease = DOTween.defaultEaseType;
        [ShowIf(nameof(_useAnimationCurve)), SerializeField] private AnimationCurve _curve;
        [SerializeField] private bool _useAdditionalSettings;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private int _id = -999;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private float _delay;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private int _loops = 1;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private LoopType _loopType = DOTween.defaultLoopType;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private UpdateType _updateType = DOTween.defaultUpdateType;

        private Tween _tween;

        public Tween Tween => _tween;

        public Action onInit;

        #region MonoBehaviour

        protected virtual void OnDestroy()
        {
            _tween.Kill();
        }

        #endregion

        public abstract Tween CreateForwardTween();

        public abstract Tween CreateBackwardTween();

        public abstract void MoveToStartState();

        public abstract void MoveToEndState();

        private void InitForward()
        {
            _tween = CreateForwardTween();

            onInit?.Invoke();
        }

        private void InitBackward()
        {
            _tween = CreateBackwardTween();

            onInit?.Invoke();
        }

        private void ApplyAnimationPreferences()
        {
            if (_useAdditionalSettings)
            {
                _tween.SetId(_id);
                _tween.SetDelay(_delay);
                _tween.SetLoops(_loops, _loopType);
                _tween.SetUpdate(_updateType);
                _tween.SetAutoKill(true);
            }

            if (_useAnimationCurve)
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
            if (CanPlay())
            {
                PlayForwardImmediate();
            }
        }

        public void PlayBackward()
        {
            if (CanPlay())
            {
                PlayBackwardImmediate();
            }
        }

        public void PlayForwardImmediate()
        {
            _tween.Kill();
            InitForward();
            ApplyAnimationPreferences();
            _tween.Play();
        }

        public void PlayBackwardImmediate()
        {
            _tween.Kill();
            InitBackward();
            ApplyAnimationPreferences();
            _tween.Play();
        }

        public void PlayFromStart()
        {
            if (CanPlay())
            {
                PlayFromStartImmediate();
            }
        }

        public void PlayFromEnd()
        {
            if (CanPlay())
            {
                PlayFromEndImmediate();
            }
        }

        public void PlayFromStartImmediate()
        {
            MoveToStartState();
            PlayForwardImmediate();
        }

        public void PlayFromEndImmediate()
        {
            MoveToEndState();
            PlayBackwardImmediate();
        }

        private bool CanPlay()
        {
            return _tween == null || _tween.active == false;
        }
    }
}
