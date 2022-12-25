﻿using CBA.Animations.Graphics.Color.Channel.Core;
using CBA.Extensions;

namespace CBA.Animations.Graphics.Color.Channel
{
    public class ColorGreenChannelAnimation : ColorChannelAnimationCore
    {
        protected override float _channel
        {
            get => _colorAdapter.color.g;
            set => _colorAdapter.color = _colorAdapter.color.WithGreen(value);
        }
    }
}
