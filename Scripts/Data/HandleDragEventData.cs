﻿namespace UnityEngine.VR.Handles
{
	/// <summary>
	/// Event data for BaseHandle.DragEventCallback
	/// </summary>
	public struct HandleDragEventData
	{
		public Vector3 deltaPosition;
		public Quaternion deltaRotation;
		public Transform rayOrigin;

		public HandleDragEventData(Vector3 deltaPosition, Quaternion deltaRotation, Transform rayOrigin)
		{
			this.rayOrigin = rayOrigin;
			this.deltaPosition = deltaPosition;
			this.deltaRotation = deltaRotation;
		}

		public HandleDragEventData(Vector3 deltaPosition, Transform rayOrigin)
		{
			this.rayOrigin = rayOrigin;
			this.deltaPosition = deltaPosition;
			this.deltaRotation = Quaternion.identity;
		}

		public HandleDragEventData(Quaternion deltaRotation, Transform rayOrigin)
		{
			this.rayOrigin = rayOrigin;
			this.deltaPosition = Vector3.zero;
			this.deltaRotation = deltaRotation;
		}

		public HandleDragEventData(Transform rayOrigin)
		{
			this.rayOrigin = rayOrigin;
			this.deltaPosition = Vector3.zero;
			this.deltaRotation = Quaternion.identity;
		}
	}
}