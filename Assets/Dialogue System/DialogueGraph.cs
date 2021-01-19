using System.Linq;
using Dialogue_System.Nodes;
using UnityEngine;
using XNode;

namespace Dialogue_System
{
    [CreateAssetMenu(fileName = "Dialogue Graph")]
    public class DialogueGraph : NodeGraph
    {
        public DialogueNode current;
        public DialogueTest dialogueController;
        public void Restart()
        {
            current = nodes.Find(x => x is Chat && x.Inputs.All(y => !y.IsConnected)) as Chat;
        }
    }
}
