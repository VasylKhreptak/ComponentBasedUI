using UnityEngine;

namespace ComponentBasedUI.Extensions
{
    public static class Gizmos
    {
        public static void DrawArrow(Vector3 position, Vector3 direction, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20.0f)
        {
            if (direction == Vector3.zero) return;

            UnityEngine.Gizmos.DrawRay(position, direction);

            Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
            Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);
            Vector3 up = Quaternion.LookRotation(direction) * Quaternion.Euler(180 + arrowHeadAngle, 0, 0) * new Vector3(0, 0, 1);
            Vector3 down = Quaternion.LookRotation(direction) * Quaternion.Euler(180 - arrowHeadAngle, 0, 0) * new Vector3(0, 0, 1);

            UnityEngine.Gizmos.DrawRay(position + direction, right * arrowHeadLength);
            UnityEngine.Gizmos.DrawRay(position + direction, left * arrowHeadLength);
            UnityEngine.Gizmos.DrawRay(position + direction, up * arrowHeadLength);
            UnityEngine.Gizmos.DrawRay(position + direction, down * arrowHeadLength);
        }

        public static void DrawAngle(Vector3 center, Vector3 from, Vector3 to, float radius,
            Color arcColor, Color wireArcColor)
        {
            float angle = Vector3.Angle(from, to);

            if (Mathf.Approximately(angle, 0)) return;

            Vector3 arcNormal = Vector3.Cross(from, to).normalized;
            Vector3 fromEndPoint = center + (from * radius);
            Vector3 toEndPoint = center + (to * radius);
            float endPointSize = radius / 50f;
            Vector3 secondArrowPoint = center + ((Quaternion.AngleAxis(-5f, arcNormal) * to) * radius);

            UnityEngine.Gizmos.DrawSphere(fromEndPoint, endPointSize);
            UnityEditor.Handles.color = arcColor;
            UnityEditor.Handles.DrawSolidArc(center, arcNormal, from, angle, radius);
            UnityEditor.Handles.color = wireArcColor;
            UnityEditor.Handles.DrawWireArc(center, arcNormal, from, angle, radius);
            UnityEngine.Gizmos.color = wireArcColor;
            DrawArrow(toEndPoint, toEndPoint - secondArrowPoint);
        }
    }
}
