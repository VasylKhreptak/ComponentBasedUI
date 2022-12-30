using CBA.Sequences.Actions.Core;
using DG.Tweening;

namespace CBA.Sequences.Actions
{
    public class TogglePauseSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.Sequence.TogglePause();
        }
    }
}
