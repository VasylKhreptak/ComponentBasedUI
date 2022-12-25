using CBA.Animations.Graphics.Color.Channel.Core;
using CBA.Extensions;

namespace CBA.Animations.Graphics.Color.Channel
{
    public class ColorBlueChannelAnimation: ColorChannelAnimationCore
    {
        protected override float _channel
        {
            get => _colorAdapter.color.b;
            set => _colorAdapter.color = _colorAdapter.color.WithBlue(value);
        }
    }
}
