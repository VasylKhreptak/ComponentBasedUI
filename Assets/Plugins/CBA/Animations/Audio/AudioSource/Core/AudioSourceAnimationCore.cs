using CBA.Animations.Core;
using NaughtyAttributes;
using UnityEngine;

namespace CBA.Animations.Audio.AudioSource.Core
{
    public abstract class AudioSourceAnimationCore : AnimationCore
    {
        [Header("References")]
        [Required, SerializeField] protected UnityEngine.AudioSource _audioSource;

        #region MonoBehaviour

        private void OnValidate()
        {
            _audioSource ??= GetComponent<UnityEngine.AudioSource>();
        }

        #endregion
    }
}
