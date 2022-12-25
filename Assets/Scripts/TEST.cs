using System;
using CBA.Adapters.Alpha.Core;
using DG.Tweening;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

public class TEST : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private AlphaAdapter _alphaAdapter;

    [Header("Preferences")]
    [SerializeField] private float _startAlpha;
    [SerializeField] private float _targetAlpha;

    [Button("Set Start")]
    private void SetStart()
    {
        _alphaAdapter.alpha = _startAlpha;
    }

    [Button("Set Target")]
    private void SetTarget()
    {
        _alphaAdapter.alpha = _targetAlpha;
    }
}
