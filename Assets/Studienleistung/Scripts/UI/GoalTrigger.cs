using UnityEngine;
using System.Collections;

/// <summary>
/// Goal trigger.
/// </summary>
public class GoalTrigger : MonoBehaviour
{

	private WinPanel m_winPanel;

	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake ()
	{
		m_winPanel = WinPanel.Instance ();
	}

	/// <summary>
	/// Raises the trigger enter event.
	/// </summary>
	/// <param name="collider">Collider.</param>
	void OnTriggerEnter (Collider collider)
	{
		m_winPanel.OpenPanel ();
		GameManager.Instance ().Won ();
	}
}
