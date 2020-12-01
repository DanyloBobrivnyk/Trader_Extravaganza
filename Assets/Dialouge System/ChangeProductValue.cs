using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using XNode;

namespace Dialouge_System
{
	public class ChangeProductValue : EventNode
	{
		[Input(backingValue = ShowBackingValue.Never)] public Node input;
		[Output(backingValue = ShowBackingValue.Never)] public Node output;
	
		public City city;
		public ProductTypes productType;
		public int valueChange;
		// Use this for initialization
		protected override void Init() {
			base.Init();
		
		}

		// Return the correct value of an output port when requested
		public override object GetValue(NodePort port) {
			return null; // Replace this
		}

		public override void Trigger()
		{
			city.ChangeProductPrice(productType, valueChange);
			NodePort port = GetOutputPort("output");
			if (port == null) return;
			
			NodePort connection = port.GetConnection(0);
			(connection.node as EventNode)?.Trigger();
			(graph as SimpleGraph).current = connection.node as EventNode;
		}
	}

	public abstract class EventNode : Node
	{
		public abstract void Trigger();
	}
}