using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;

[System.Serializable, NodeMenuItem("Custom/PortConnectionTests")]
public class PortConnectionTests : BaseNode
{
	[Input]
	public IEnumerable< object >	inputs = null;

	[Output]
	public IEnumerable< object >	outputs;

    public float padding;

	public override string		name => "Port Tests";

	protected override void Process() {}

    protected override bool hasCustomInputs => true;
    protected override bool hasCustomOutputs => true;

    protected override IEnumerable<PortData> GetCustomInputPorts()
    {
        yield return new PortData { displayName = "In 0", displayType = typeof(float), identifier = 0 };
        yield return new PortData { displayName = "In 1", displayType = typeof(Color), identifier = 1 };
        yield return new PortData { displayName = "In 2", displayType = typeof(Vector4), identifier = 2 };
        yield return new PortData { displayName = "In 3", displayType = typeof(GameObject), identifier = 3 };
        yield return new PortData { displayName = "In 4", displayType = typeof(float), identifier = 4 };
        yield return new PortData { displayName = "In 5", displayType = typeof(Color), identifier = 5 };
        yield return new PortData { displayName = "In 6", displayType = typeof(Vector4), identifier = 6 };
        yield return new PortData { displayName = "In 7", displayType = typeof(GameObject), identifier = 7 };
    }

    protected override IEnumerable<PortData> GetCustomOutputPorts()
    {
        yield return new PortData{ displayName = "Out 0", displayType = typeof(float), identifier = 10 };
        yield return new PortData{ displayName = "Out 1", displayType = typeof(Color), identifier = 11 };
        yield return new PortData{ displayName = "Out 2", displayType = typeof(Vector4), identifier = 12 };
        yield return new PortData{ displayName = "Out 3", displayType = typeof(GameObject), identifier = 13 };
        yield return new PortData{ displayName = "Out 4", displayType = typeof(float), identifier = 14 };
        yield return new PortData{ displayName = "Out 5", displayType = typeof(Color), identifier = 15 };
        yield return new PortData{ displayName = "Out 6", displayType = typeof(Vector4), identifier = 16 };
        yield return new PortData{ displayName = "Out 7", displayType = typeof(GameObject), identifier = 17 };
	}
}
