using System.Collections.Generic;
using System.Reflection;

namespace NodeGraphProcessor.Examples
{
	public interface IConditionalNode
	{
		IEnumerable<IConditionalNode>	GetExecutedNodes();

		FieldInfo[] GetNodeFields(); // Provide a custom order for fields (so conditional links are always at the top of the node)
	}
}