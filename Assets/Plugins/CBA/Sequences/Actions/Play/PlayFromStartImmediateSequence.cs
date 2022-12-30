using CBA.Sequences.Actions.Core;

namespace CBA.Sequences.Actions.Play
{
    public class PlayFromStartImmediateSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.PlayFromStartImmediate();
        }
    }
}
