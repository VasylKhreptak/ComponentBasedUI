using CBA.Animations.RectTransform.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.RectTransform.Jump
{
    public class AnchorJumpAnimation : RectTransformAnimationCore
    {
        [Header("Jump Preferences")]
        [SerializeField] private Vector2 _startAnchoredPosition;
        [SerializeField] private Vector3 _targetAnchoredPosition;
        [SerializeField] protected float _power = 2f;
        [SerializeField] protected int _jumpsNumber = 1;

        [Header("Snapping")]
        [SerializeField] protected bool _snapping;

        protected override Tween CreateForwardTween()
        {
            return _rectTransform.DOJumpAnchorPos(_targetAnchoredPosition, _power, _jumpsNumber, _duration, _snapping);
        }

        protected override Tween CreateBackwardTween()
        {
            return _rectTransform.DOJumpAnchorPos(_startAnchoredPosition, _power, _jumpsNumber, _duration, _snapping);
        }

        protected override void MoveToStartState()
        {
            _rectTransform.anchoredPosition = _startAnchoredPosition;
        }

        protected override void MoveToEndState()
        {
            _rectTransform.anchoredPosition = _targetAnchoredPosition;
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Anchor Position")]
        private void AssignStartPosition()
        {
            if (_isRecording) return;

            _startAnchoredPosition = _rectTransform.anchoredPosition;
        }

        [Button("Assign Target Anchor Position")]
        private void AssignTargetPosition()
        {
            if (_isRecording) return;

            _targetAnchoredPosition = _rectTransform.anchoredPosition;
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
            _startAnchoredPosition = _rectTransform.anchoredPosition;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _targetAnchoredPosition = _rectTransform.anchoredPosition;
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
