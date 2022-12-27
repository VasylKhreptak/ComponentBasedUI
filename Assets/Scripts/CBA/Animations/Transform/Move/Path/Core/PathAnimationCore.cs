using System.Collections.Generic;
using CBA.Animations.Transform.Core;
using DG.Tweening;
using UnityEngine;

namespace CBA.Animations.Transform.Move.Path.Core
{
    public abstract class PathAnimationCore : TransformAnimationCore
    {
        [Header("Path Preferences")]
        [SerializeField] protected List<PositionProvider.Core.PositionProvider> _positionProviders;
        [SerializeField] protected PathType _pathType = PathType.Linear;
        [SerializeField] protected PathMode _pathMode = PathMode.Full3D;
        [SerializeField] protected int _resolution = 10;
    }
}
