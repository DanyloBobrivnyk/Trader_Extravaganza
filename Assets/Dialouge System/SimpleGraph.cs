using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dialouge_System;
using UnityEngine;
using XNode;
[CreateAssetMenu(fileName = "Simple Graph")]
public class SimpleGraph : NodeGraph
{
    public EventNode current;

    public void Restart()
    {
        current = nodes.Find(x => x is Chat && x.Inputs.All(y => !y.IsConnected)) as Chat;
    }
}
