using ComponentBasedUI.Actions.Core;
using NaughtyAttributes;
using UnityEngine;

namespace ComponentBasedUI.Actions.Management.Scene.Core
{
    public abstract class SceneAction : Action
    {
        [Header("References")]
        [Scene, SerializeField] protected string _scene;
    }
}
