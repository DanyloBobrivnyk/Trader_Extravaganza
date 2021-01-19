﻿using System.Collections;
using System.Collections.Generic;
using Dialogue_System;
using Dialogue_System.Nodes;
using UnityEngine;
using XNode;

public class EndDialogueEvent : DialogueNode
{
    
    // Return the correct value of an output port when requested
    public override object GetValue(NodePort port) {
        return null; // Replace this
    }
    public override void Trigger()
    {
        ((DialogueGraph) graph).dialogueController.EndDialogue();
    }
}
