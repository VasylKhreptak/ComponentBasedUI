using UnityEngine;
using Animation = ComponentBasedUI.Animations.Core.Animation;

namespace ComponentBasedUI.Animations.MoveAnimation.Core
{
    public abstract class MoveAnimationCore : Animation
    {
        [Header("References")]
        [SerializeField] protected Transform _transform;

        #region MonoBehaviour

        private void OnValidate()
        {
            _transform ??= GetComponent<Transform>();
        }

        #endregion

        protected abstract void AssignStartPositionVariable();

        protected abstract void AssignTargetPosition();

        protected abstract void MoveToStartPosition();

        protected abstract void MoveToTargetPosition(); 

        #region Gizmos

        private void OnDrawGizmosSelected()
        {
            if (_transform == null) return;

            DrawGizmosSelected();
        }

        protected abstract void DrawGizmosSelected();

        #endregion
    }
}
