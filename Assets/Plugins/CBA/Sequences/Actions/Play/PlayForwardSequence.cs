using CBA.Sequences.Actions.Core;

namespace CBA.Sequences.Actions.Play
{
    public class PlayForwardSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.PlayForward();
        }
    }
}
