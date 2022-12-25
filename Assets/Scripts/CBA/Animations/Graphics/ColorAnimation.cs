using CBA.Adapters.Color.Core;
using CBA.Animations.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Graphics
{
    public class ColorAnimation : AnimationCore
    {
        [Header("References")]
        [Required, SerializeField] private ColorAdapter _colorAdapter;

        [Header("Fade Preferences")]
        [SerializeField] private Color _startColor = Color.white;
        [SerializeField] private Color _targetColor = Color.white;

        #region MonoBehaviour

        private void OnValidate()
        {
            _colorAdapter ??= GetComponent<ColorAdapter>();
        }

        #endregion

        protected override Tween CreateForwardTween()
        {
            return DOTween.To(() => _colorAdapter.color, x => _colorAdapter.color = x, _targetColor, _duration);
        }

        protected override Tween CreateBackwardTween()
        {
            return DOTween.To(() => _colorAdapter.color, x => _colorAdapter.color = x, _startColor, _duration);
        }

        protected override void MoveToStartState()
        {
            _colorAdapter.color = _startColor;
        }

        protected override void MoveToEndState()
        {
            _colorAdapter.color = _targetColor;
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Alpha")]
        private void AssignStartAlpha()
        {
            if (_isRecording) return;

            _startColor = _colorAdapter.color;
        }

        [Button("Assign Target Alpha")]
        private void AssignTargetAlpha()
        {
            if (_isRecording) return;

            _targetColor = _colorAdapter.color;
        }

        [Button("Set Start Color")]
        private void SetStartColor()
        {
            if (_isRecording) return;

            MoveToStartState();
        }

        [Button("Set Target Color")]
        private void SetTargetColor()
        {
            if (_isRecording) return;

            MoveToEndState();
        }

        [Button("Start Recording")]
        private void StartRecording()
        {
            _startColor = _colorAdapter.color;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _targetColor = _colorAdapter.color;
            MoveToStartState();

            _isRecording = false;
        }

#endif

        #endregion
    }
}
