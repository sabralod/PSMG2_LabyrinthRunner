using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
/// <summary>
/// ButtonPanel: Represents the open button in UI. Enable a new listener when it activated.
/// </summary>
public class ButtonPanel : MonoBehaviour
{
	public Button button;
	public GameObject panel;

	private static ButtonPanel m_buttonPanel;

	public static ButtonPanel Instance ()
	{
		if (!m_buttonPanel) {
			m_buttonPanel = FindObjectOfType (typeof(ButtonPanel)) as ButtonPanel;
			if (!m_buttonPanel) {
				Debug.Log ("Button panel error!");
			}
		}

		return m_buttonPanel;
	}

	/// <summary>
	/// Activates the button and add button event to it.
	/// </summary>
	/// <param name="buttonEvent">Button event.</param>
	public void ActivateButton (UnityAction buttonEvent)
	{
		panel.SetActive (true);
		button.onClick.RemoveAllListeners ();
		button.onClick.AddListener (buttonEvent);
		button.onClick.AddListener (ClosePanel);
	}

	/// <summary>
	/// Deactivates the button.
	/// </summary>
	public void DeactivateButton ()
	{
		ClosePanel ();
		button.onClick.RemoveAllListeners ();
	}

	/// <summary>
	/// Closes the panel.
	/// </summary>
	void ClosePanel ()
	{
		panel.SetActive (false);
	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start ()
	{
		DeactivateButton ();
	}
}
