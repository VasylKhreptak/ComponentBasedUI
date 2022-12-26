using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;

public class TEST : MonoBehaviour
{
    [Header("Preferences")]
    [SerializeField] private AxisConstraint _axisConstraint;

    [Button("Test")]
    private void Test()
    {
        Debug.Log(CBA.Extensions.AxisConstraint.ToVector3Int(_axisConstraint));
    }
}
