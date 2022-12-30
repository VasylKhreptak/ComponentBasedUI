using CBA.Sequences.Actions.Core;

namespace CBA.Sequences.Actions.Play
{
    public class PlayBackwardImmediateSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.PlayBackwardImmediate();
        }
    }
}
