using UnityEngine;
using ComponentBasedUI.Animations.Actions.Core;

namespace ComponentBasedUI.Animations.Actions
{
    public class AnimationActionGroup : AnimationAction
    {
        [Header("References")]
        [SerializeField] private AnimationAction[] _actions;
        
        public override void Do()
        {
            foreach (var action in _actions)
            {
                action.Do();
            }
        }
    }
}
