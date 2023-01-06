using System;
using UnityEngine;

public class EditorTargetFramerate : MonoBehaviour
{
   [Header("Preferences")]
   [SerializeField] private int _maxFramerate;

   #region MonoBehaviour

   private void OnValidate()
   {
      Application.targetFrameRate = _maxFramerate;
   }

   #endregion
}
