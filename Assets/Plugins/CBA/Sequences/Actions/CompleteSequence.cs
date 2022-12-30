using CBA.Sequences.Actions.Core;
using DG.Tweening;

namespace CBA.Sequences.Actions
{
    public class CompleteSequence : SequenceAction
    {
        public override void Do()
        {
            _sequence.Sequence.Complete();
        }
    }
}
