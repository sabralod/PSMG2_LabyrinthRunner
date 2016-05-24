using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Life panel.
/// </summary>
public class LifePanel : MonoBehaviour
{

	public GameObject statPanel;
	public Text lifePoints;

	private static LifePanel m_lifePanel;

	/// <summary>
	/// Instance this instance.
	/// </summary>
	public static LifePanel Instance ()
	{
		if (!m_lifePanel) {
			m_lifePanel = FindObjectOfType (typeof(LifePanel)) as LifePanel;
			if (!m_lifePanel) {
				Debug.Log ("Life panel error!");
			}
		}

		return m_lifePanel;
	}

	/// <summary>
	/// Sets the life to value.
	/// </summary>
	/// <param name="life">Life.</param>
	public void SetLifeTo (int life)
	{
		lifePoints.text = "Life: " + life;
	}
}
