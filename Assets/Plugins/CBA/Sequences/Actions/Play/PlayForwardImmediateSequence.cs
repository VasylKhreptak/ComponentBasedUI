using CBA.Sequences.Actions.Core;

namespace CBA.Sequences.Actions.Play
{
    public class PlayForwardImmediateSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.PlayForwardImmediate();
        }
    }
}
