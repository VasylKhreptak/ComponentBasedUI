using CBA.Sequences.Actions.Core;

namespace CBA.Sequences.Actions.Play
{
    public class PlayFromEndImmediateSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.PlayFromEndImmediate();
        }
    }
}
