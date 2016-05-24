using UnityEngine;
using System.Collections;

/// <summary>
/// Lost panel.
/// </summary>
public class LostPanel : MonoBehaviour
{

	public GameObject lostPanel;

	private static LostPanel m_lostPanel;

	/// <summary>
	/// Instance this instance.
	/// </summary>
	public static LostPanel Instance ()
	{
		if (!m_lostPanel) {
			m_lostPanel = FindObjectOfType (typeof(LostPanel)) as LostPanel;
			if (!m_lostPanel) {
				Debug.Log ("Lost panel error!");
			}
		}

		return m_lostPanel;
	}

	/// <summary>
	/// Opens the panel.
	/// </summary>
	public void OpenPanel ()
	{
		lostPanel.SetActive (true);
	}

	/// <summary>
	/// Closes the panel.
	/// </summary>
	public void ClosePanel ()
	{
		lostPanel.SetActive (false);
	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start ()
	{
		ClosePanel ();
	}
}
