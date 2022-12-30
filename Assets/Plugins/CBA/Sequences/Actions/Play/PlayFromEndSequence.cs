using CBA.Sequences.Actions.Core;

namespace CBA.Sequences.Actions.Play
{
    public class PlayFromEndSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.PlayFromEnd();
        }
    }
}
