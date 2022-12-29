using System;
using System.Collections.Generic;
using CBA.Animations.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Sequences.Core
{
    public abstract class SequenceCore : MonoBehaviour
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

        private void OnDestroy()
        {
            _sequence.Kill();
        }

        #endregion
    }
}
