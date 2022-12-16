using UnityEngine;
using ComponentBasedUI.Sequences.Actions.Core;

namespace ComponentBasedUI.Sequences.Actions
{
    public class SequenceActionGroup : SequenceAction
    {
        [Header("References")]
        [SerializeField] private SequenceAction[] _actions;

        public override void Do()
        {
            foreach (var action in _actions)
            {
                action.Do();
            }
        }
    }
}
