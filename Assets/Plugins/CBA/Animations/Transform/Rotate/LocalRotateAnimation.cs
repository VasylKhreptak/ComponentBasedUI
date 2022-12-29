using CBA.Animations.Transform.Rotate.Core;
using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Transform.Rotate
{
    public class LocalRotateAnimation : RotateAnimationCore
    {
        protected override Tween CreateForwardTween()
        {
            return _transform.DOLocalRotate(_targetAngle, _duration);
        }
        protected override Tween CreateBackwardTween()
        {
            return _transform.DOLocalRotate(_startAngle, _duration);
        }
        protected override void MoveToStartState()
        {
            _transform.localRotation = Quaternion.Euler(_startAngle);
        }
        protected override void MoveToEndState()
        {
            _transform.localRotation = Quaternion.Euler(_targetAngle);
        }

        #region Editor

#if UNITY_EDITOR

        [ShowNonSerializedField] private bool _isRecording;

        [Button("Assign Start Angle")]
        private void AssignStartAngle()
        {
            if (_isRecording) return;

            _startAngle = _transform.localRotation.eulerAngles;
        }

        [Button("Assign Target Position")]
        private void AssignTargetAngle()
        {
            if (_isRecording) return;

            _targetAngle = _transform.localRotation.eulerAngles;
        }

        [Button("Rotate To Start")]
        private void RotateToStart()
        {
            if (_isRecording) return;

            MoveToStartState();
        }

        [Button("Rotate To End")]
        private void RotateToEnd()
        {
            if (_isRecording) return;

            MoveToEndState();
        }

        [Button("Start Recording")]
        private void StartRecording()
        {
            _startAngle = _transform.localRotation.eulerAngles;

            _isRecording = true;
        }

        [Button("Stop Recording")]
        private void StopRecording()
        {
            if (_isRecording == false) return;

            _targetAngle = _transform.localRotation.eulerAngles;
            MoveToStartState();

            _isRecording = false;
        }
#endif

        #endregion
    }
}
