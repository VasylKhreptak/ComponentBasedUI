using CBA.Animations.Core;
using UnityEngine;
using UnityEngine.Audio;

namespace CBA.Animations.Audio.AudioMixer.Core
{
    public abstract class AudioMixerAnimationCore : AnimationCore
    {
        [Header("References")]
        [SerializeField] protected AudioMixerGroup _audioMixerGroup;
    }
}
