using UnityEngine;
using System.Collections;

/// <summary>
/// Helper class. Brings UI elements to front.
/// </summary>
public class BringToFront : MonoBehaviour {

	/// <summary>
	/// Raises the enable event.
	/// </summary>
	void OnEnable() {
		transform.SetAsLastSibling ();
	}
}
