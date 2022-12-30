using CBA.Sequences.Actions.Core;

namespace CBA.Sequences.Actions.Play
{
    public class PlayBackwardSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.PlayBackward();
        }
    }
}
