using System;
using System.Collections.Generic;
using System.Linq;
using CBA.Animations.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Sequences.Core
{
    public class AnimationSequence : MonoBehaviour
    {
        [Header("Animations")]
        [SerializeField] private List<AnimationCore> _animations;

        [Header("Sequence Preferences")]
        [SerializeField] private bool _useAnimationCurve;
        [HideIf(nameof(_useAnimationCurve)), SerializeField] private Ease _ease = DOTween.defaultEaseType;
        [ShowIf(nameof(_useAnimationCurve)), SerializeField] private AnimationCurve _curve;
        [SerializeField] private bool _useAdditionalSettings;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private int _id = -999;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private float _delay;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private int _loops = 1;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private LoopType _loopType = DOTween.defaultLoopType;
        [ShowIf(nameof(_useAdditionalSettings)), SerializeField] private UpdateType _updateType = DOTween.defaultUpdateType;

        private Sequence _sequence;

        public Sequence Sequence => _sequence;

        public Action onInit;

        #region MonoBehaviour

        private void OnValidate()
        {
            if (_animations == null || _animations.Count == 0)
            {
                _animations = transform.GetComponentsInChildren<AnimationCore>().ToList();
            }
        }

        private void OnDestroy()
        {
            _sequence.Kill();
        }

        #endregion

        private void ApplyAnimationPreferences()
        {
            if (_useAdditionalSettings)
            {
                _sequence.SetId(_id);
                _sequence.SetDelay(_delay);
                _sequence.SetLoops(_loops, _loopType);
                _sequence.SetUpdate(_updateType);
                _sequence.SetAutoKill(true);
            }

            if (_useAnimationCurve)
            {
                _sequence.SetEase(_curve);
            }
            else
            {
                _sequence.SetEase(_ease);
            }
        }

        private void InitForward()
        {
            _sequence = CreateForwardSequence();

            onInit?.Invoke();
        }

        private void InitBackward()
        {
            _sequence = CreateBackwardSequence();

            onInit?.Invoke();
        }

        private List<AnimationCore> GetReversedAnimations()
        {
            List<AnimationCore> animations = new List<AnimationCore>(_animations);
            animations.Reverse();
            return animations;
        }

        private Sequence CreateForwardSequence()
        {
            Sequence sequence = DOTween.Sequence();

            foreach (var animationCore in _animations)
            {
                sequence.Append(animationCore.CreateForwardTween());
            }

            return sequence;
        }

        private Sequence CreateBackwardSequence()
        {
            Sequence sequence = DOTween.Sequence();

            foreach (var animationCore in GetReversedAnimations())
            {
                sequence.Append(animationCore.CreateBackwardTween());
            }

            return sequence;
        }

        private void MoveToStartState()
        {
            foreach (var animationCore in _animations)
            {
                animationCore.MoveToStartState();
            }
        }

        private void MoveToEndState()
        {
            foreach (var animationCore in _animations)
            {
                animationCore.MoveToEndState();
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
            _sequence.Kill();
            InitForward();
            ApplyAnimationPreferences();
            _sequence.Play();
        }

        public void PlayBackwardImmediate()
        {
            _sequence.Kill();
            InitBackward();
            ApplyAnimationPreferences();
            _sequence.Play();
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
            return _sequence == null || _sequence.active == false;
        }
    }
}
