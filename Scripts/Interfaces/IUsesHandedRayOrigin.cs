﻿using UnityEngine.Experimental.EditorVR.Tools;

namespace UnityEngine.Experimental.EditorVR
{
	/// <summary>
	/// Adds Node information to IUsesRayOrigin to determine which hand the tool is attached to
	/// </summary>
	public interface IUsesHandedRayOrigin : IUsesRayOrigin, IUsesNode
	{
	}
}
