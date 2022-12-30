using CBA.Sequences.Actions.Core;

namespace CBA.Sequences.Actions.Play
{
    public class PlayFromStartSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.PlayFromStart();
        }
    }
}
