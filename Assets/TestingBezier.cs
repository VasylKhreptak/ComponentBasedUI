using UnityEngine;

public class TestingBezier : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform[] _points;

    private float _interpolateAmount;

    private void FixedUpdate()
    {
        _interpolateAmount = (_interpolateAmount + Time.deltaTime) % 1f;
        //_target.position = CBA.Extensions.Vector3.CubicLerp(A.position, B.position, C.position, D.position, _interpolateAmount);
    }
}
