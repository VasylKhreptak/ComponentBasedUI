using ComponentBasedUI.Actions.Core;
using UnityEngine;

namespace ComponentBasedUI.Actions
{
    public class ActionGroup : Action
    {
        [Header("References")]
        [SerializeField] private Action[] _actions;

        public override void Do()
        {
            foreach (var action in _actions)
            {
                action.Do();
            }
        }
    }
}
