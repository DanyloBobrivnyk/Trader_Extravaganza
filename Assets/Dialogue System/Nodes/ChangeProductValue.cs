﻿using XNode;

namespace Dialogue_System.Nodes
{
	public class ChangeProductValue : DialogueNode
	{
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
			(connection.node as DialogueNode)?.Trigger();
			(graph as DialogueGraph).current = connection.node as DialogueNode;
		}
	}
}