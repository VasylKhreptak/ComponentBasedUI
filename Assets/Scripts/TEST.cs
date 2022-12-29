using System;
using UnityEngine;

public class TEST : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private RectTransform _rectTransform;

    private void Awake()
    {
    }

    private void OnDrawGizmos()
    {
        if (_rectTransform == null) return;

        Gizmos.color = Color.red;
    }

}
