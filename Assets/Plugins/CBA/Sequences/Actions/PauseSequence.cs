using CBA.Sequences.Actions.Core;
using DG.Tweening;

namespace CBA.Sequences.Actions
{
    public class PauseSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.Sequence.Pause();
        }
    }
}
