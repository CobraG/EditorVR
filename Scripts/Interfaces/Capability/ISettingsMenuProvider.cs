﻿#if UNITY_EDITOR
using UnityEngine;

namespace UnityEditor.Experimental.EditorVR
{
	/// <summary>
	/// Decorates types that can provide a sub-menu on the Settings menu. The class should also use a MainMenuItemAttribute
	/// </summary>
	public interface ISettingsMenuProvider
	{
		/// <summary>
		/// The menu face prefab which will be added to the menu
		/// </summary>
		GameObject settingsMenuPrefab { get; }

		/// <summary>
		/// An instance of the menu face prefab that was added to the menu
		/// </summary>
		GameObject settingsMenuInstance { set; }

		/// <summary>
		/// The rayOrigin this provider is associated with. This will determine which menu is used. If null, both menus are used
		/// </summary>
		Transform rayOrigin { get; }
	}
}
#endif