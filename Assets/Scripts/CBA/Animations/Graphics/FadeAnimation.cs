using CBA.Adapters.Alpha.Core;
using CBA.Animations.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Graphics
{
    public class FadeAnimation : AnimationCore
    {
        [Header("References")]
        [Required, SerializeField] private AlphaAdapter _alphaAdapter;

        [Header("Fade Preferences")]
        [SerializeField] private float _startAlpha;
        [SerializeField] private float _targetAlpha = 1f;

        #region MonoBehaviour

        private void OnValidate()
        {
            _alphaAdapter ??= GetComponent<AlphaAdapter>();
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return DOTween.To(() => _alphaAdapter.alpha, x => _alphaAdapter.alpha = x, _targetAlpha, _duration);
        }

        protected override Tween CreateBackwardTween()
        {
            return DOTween.To(() => _alphaAdapter.alpha, x => _alphaAdapter.alpha = x, _startAlpha, _duration);
        }

        protected override void MoveToStartState()
        {
            _alphaAdapter.alpha = _startAlpha;
        }

        protected override void MoveToEndState()
        {
            _alphaAdapter.alpha = _targetAlpha;
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Alpha")]
        private void AssignStartAlpha()
        {
            if (_isRecording) return;

            _startAlpha = _alphaAdapter.alpha;
        }

        [Button("Assign Target Alpha")]
        private void AssignTargetAlpha()
        {
            if (_isRecording) return;

            _targetAlpha = _alphaAdapter.alpha;
        }

        [Button("Set Start Alpha")]
        private void SetStartAlpha()
        {
            if (_isRecording) return;

            MoveToStartState();
        }

        [Button("Set Target Alpha")]
        private void SetTargetAlpha()
        {
            if (_isRecording) return;

            MoveToEndState();
        }

        [Button("Start Recording")]
        private void StartRecording()
        {
            _startAlpha = _alphaAdapter.alpha;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _targetAlpha = _alphaAdapter.alpha;
            MoveToStartState();

            _isRecording = false;
        }

#endif

        #endregion

    }
}
