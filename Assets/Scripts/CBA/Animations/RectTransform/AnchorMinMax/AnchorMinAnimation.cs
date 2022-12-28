using CBA.Animations.RectTransform.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.RectTransform.AnchorMinMax
{
    public class AnchorMinAnimation : RectTransformAnimationCore
    {
        [Header("Move Preferences")]
        [SerializeField] private Vector2 _startAnchorMin;
        [SerializeField] private Vector2 _targetAnchorMin;

        [Header("Snapping")]
        [SerializeField] private bool _snapping;

        protected override Tween CreateForwardTween()
        {
            return _rectTransform.DOAnchorMin(_targetAnchorMin, _duration, _snapping);
        }

        protected override Tween CreateBackwardTween()
        {
            return _rectTransform.DOAnchorMin(_startAnchorMin, _duration, _snapping);
        }

        protected override void MoveToStartState()
        {
            _rectTransform.anchorMin = _startAnchorMin;
        }

        protected override void MoveToEndState()
        {
            _rectTransform.anchorMin = _targetAnchorMin;
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Anchor Position")]
        private void AssignStartPosition()
        {
            if (_isRecording) return;

            _startAnchorMin = _rectTransform.anchorMin;
        }

        [Button("Assign Target Anchor Position")]
        private void AssignTargetPosition()
        {
            if (_isRecording) return;

            _targetAnchorMin = _rectTransform.anchorMin;
        }

        [Button("Move To Start")]
        private void MoveToStartPositionEditor()
        {
            if (_isRecording) return;

            MoveToStartState();
        }

        [Button("Move To End")]
        private void MoveToTargetPosition()
        {
            if (_isRecording) return;

            MoveToEndState();
        }

        [Button("Start Recording")]
        private void StartRecording()
        {
            _startAnchorMin = _rectTransform.anchorMin;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _targetAnchorMin = _rectTransform.anchorMin;
            MoveToStartState();

            _isRecording = false;
        }

        private void OnDrawGizmosSelected()
        {
            if (_rectTransform == null) return;

            if (_isRecording)
            {
                DrawRecordingArrow();
            }
            else
            {
                DrawDefaultArrow();
            }
        }

        private void DrawDefaultArrow()
        {
            // Vector2 direction = _targetAnchoredPosition - _startAnchoredPosition;
            // Vector3 startPosition = _rectTransform.TransformPoint(_startAnchoredPosition);
            //
            // Gizmos.color = Color.white;
            // Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

        private void DrawRecordingArrow()
        {
            // Vector2 anchoredPosition = _rectTransform.anchoredPosition;
            // Vector2 direction = anchoredPosition - _startAnchoredPosition;
            // Vector3 startPosition = _rectTransform.TransformPoint(_startAnchoredPosition);
            //
            // Gizmos.color = Color.red;
            // Gizmos.DrawSphere(_startAnchoredPosition, 0.1f);
            // Extensions.Gizmos.DrawArrow(startPosition, direction);
        }

#endif

        #endregion
    }
}
