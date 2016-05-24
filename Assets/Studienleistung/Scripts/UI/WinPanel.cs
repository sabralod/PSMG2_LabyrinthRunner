using UnityEngine;
using System.Collections;

/// <summary>
/// Window panel. Represents the win message dialog in UI.
/// </summary>
public class WinPanel : MonoBehaviour
{

	public GameObject winPanel;

	private static WinPanel m_winPanel;

	/// <summary>
	/// Instance this instance.
	/// </summary>
	public static WinPanel Instance ()
	{
		if (!m_winPanel) {
			m_winPanel = FindObjectOfType (typeof(WinPanel)) as WinPanel;
			if (!m_winPanel) {
				Debug.Log ("Win panel error!");
			}
		}

		return m_winPanel;
	}

	/// <summary>
	/// Opens the panel.
	/// </summary>
	public void OpenPanel ()
	{
		winPanel.SetActive (true);
	}

	/// <summary>
	/// Closes the panel.
	/// </summary>
	public void ClosePanel ()
	{
		winPanel.SetActive (false);
	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start ()
	{
		ClosePanel ();
	}
}
