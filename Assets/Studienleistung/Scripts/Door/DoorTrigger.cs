using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Door trigger. Trigger when the player enters the collider.
/// </summary>
public class DoorTrigger : MonoBehaviour
{

	public Door door;
	private ButtonPanel m_buttonPanel;

	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake ()
	{
		m_buttonPanel = ButtonPanel.Instance ();
	}

	/// <summary>
	/// Raises the trigger enter event. Show the open button in UI.
	/// </summary>
	/// <param name="collider">Collider.</param>
	void OnTriggerEnter (Collider collider)
	{
		// If the button is pressed, pass the click event to door.
		if (!door.isOpen)
			m_buttonPanel.ActivateButton (door.OpenDoor);
	}

	/// <summary>
	/// Raises the trigger exit event. Player is out of range. Hide button in UI.
	/// </summary>
	/// <param name="collider">Collider.</param>
	void OnTriggerExit (Collider collider)
	{
		m_buttonPanel.DeactivateButton ();
	}
}
