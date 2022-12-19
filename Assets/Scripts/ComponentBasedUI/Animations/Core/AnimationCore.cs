using System;

namespace ComponentBasedUI.Animations.Core
{
    public abstract class AnimationCore : UnityEngine.MonoBehaviour
    {
        public Action onInit;
        
        public abstract void Init();

        public abstract DG.Tweening.Tween GetTween();

        public abstract void PlayFromStart();
    }
}
