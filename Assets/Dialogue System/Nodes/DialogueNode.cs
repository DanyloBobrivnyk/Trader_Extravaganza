using XNode;

namespace Dialogue_System.Nodes
{
    public abstract class DialogueNode : Node
    {
        [Input(backingValue = ShowBackingValue.Never)] public Node input;
        [Output(backingValue = ShowBackingValue.Never)] public Node output;
        public abstract void Trigger();
    }
}