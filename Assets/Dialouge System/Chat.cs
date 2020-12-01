// SimpleNode.cs

using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using XNode;

namespace Dialouge_System
{
    [CreateAssetMenu]
    public class Chat : EventNode { 
        [Input] public float input;

        [TextArea] public string text;
        [Output(dynamicPortList = true)][TextArea] public List<string> answers;

        // public override object GetValue(NodePort port) {
        //     if (port.fieldName == "b") return GetInputValue<float>("a", a);
        //     else return null;
        // }
        
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
                (connection.node as EventNode)?.Trigger();
            }
        }

        public override void Trigger()
        {
            Debug.Log("Triggering");
            (graph as SimpleGraph).current = this;
        }
    }
}