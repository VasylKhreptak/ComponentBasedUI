using CBA.Animations.Graphics.Color.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Graphics.Color.Channel.Core
{
    public abstract class ColorChannelAnimationCore : ColorAnimationCore
    {
        [Header("Color Preferences")]
        [SerializeField, Range(0f, 1f)] protected float _from;
        [SerializeField, Range(0f, 1f)] protected float _to;

        protected abstract float _channel { get; set; }

        protected override Tween CreateForwardTween()
        {
            return DOTween.To(() => _channel, x => _channel = x, _to, _duration);
        }

        protected override Tween CreateBackwardTween()
        {
            return DOTween.To(() => _channel, x => _channel = x, _from, _duration);
        }

        protected override void MoveToStartState()
        {
            _channel = _from;
        }

        protected override void MoveToEndState()
        {
            _channel = _to;
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Channel")]
        private void AssignStartChannel()
        {
            if (_isRecording) return;

            _from = _channel;
        }

        [Button("Assign Target Channel")]
        private void AssignTargetChannel()
        {
            if (_isRecording) return;

            _to = _channel;
        }

        [Button("Set Start Channel")]
        private void SetStartChannel()
        {
            if (_isRecording) return;

            MoveToStartState();
        }

        [Button("Set Target Channel")]
        private void SetTargetChannel()
        {
            if (_isRecording) return;

            MoveToEndState();
        }

        [Button("Start Recording")]
        private void StartRecording()
        {
            _from = _channel;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _to = _channel;
            MoveToStartState();

            _isRecording = false;
        }

#endif

        #endregion
    }
}
