using CBA.Actions.Core;
using CBA.Animations.Core;
using CBA.Sequences.Core;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Sequences.Actions.Core
{
    public abstract class SequenceAction : Action
    {
        [Header("References")]
        [Required, SerializeField] protected AnimationSequence _sequence;

        #region MonoBehaviour

        private void OnValidate()
        {
            _sequence ??= GetComponent<AnimationSequence>();
            _sequence ??= transform.parent.GetComponent<AnimationSequence>();
        }

        #endregion
    }
}
