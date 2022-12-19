using System;
using ComponentBasedUI.Animations.Core;
using ComponentBasedUI.EventListeners;
using UnityEngine;

public class TEST : MonoEventListener
{
    [Header("References")]
    [SerializeField] private AnimationCore _animation;

    private void OnEnable()
    {
        _animation.GetTween().onPlay += OnPlay;
    }

    private void OnDisable()
    {
        _animation.GetTween().onPlay -= OnPlay;
    }

    private void OnPlay()
    {
        Debug.Log("OnPlay");
    }
    protected override void OnEventFired()
    {
        throw new NotImplementedException();
    }
}
