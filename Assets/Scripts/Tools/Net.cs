using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : ToolNamespace.Tool {

	public Net()
    {
		InitializeVariables();
	}

    public override void UseTool(Vector2 pos)  {
        throw new System.NotImplementedException();
    }

    public override void InitializeVariables() {
		
	}
	
	// Update is called once per frame
	public override void UpdateToolState() {
        Debug.Log("Net Swipe");
	}
}
