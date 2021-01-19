// SimpleNode.cs

using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace Dialogue_System.Nodes
{
    [CreateAssetMenu]
    public class Chat : DialogueNode {

        [TextArea] public string text;
        [Output(dynamicPortList = true)][TextArea] public List<string> answers;

        public void AnswerQuestion(int index) {
            NodePort port = null;
            if (answers.Count == 0) {
                port = GetOutputPort("output");
            } else {
                if (answers.Count <= index) return;
                port = GetOutputPort("answers " + index);
            }

            if (port == null) return;
            for (int i = 0; i < port.ConnectionCount; i++) {
                NodePort connection = port.GetConnection(i);
                (connection.node as DialogueNode)?.Trigger();
            }
        }

        public override void Trigger()
        {
            ((DialogueGraph) graph).current = this;
        }
    }
}