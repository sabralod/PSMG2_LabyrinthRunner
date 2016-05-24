using UnityEngine;
using System.Collections;

/// <summary>
/// Player manager.
/// </summary>
public class PlayerManager : MonoBehaviour
{

	private int m_healthPoint;
	private float m_speed;
	private LifePanel m_lifePanel;

	/// <summary>
	/// Gets the health.
	/// </summary>
	/// <value>The health.</value>
	public int Health {
		get { return m_healthPoint; }
	}

	/// <summary>
	/// Gets the speed.
	/// </summary>
	/// <value>The speed.</value>
	public float Speed {
		get { return m_speed; }
	}

	// Want to set them in the inspector.
	public int health = 10;
	public float speed = 10f;
	public int minHealth = 0;
	public int minSpeed = 3;

	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake ()
	{
		m_lifePanel = LifePanel.Instance ();
		m_healthPoint = health;
		m_speed = speed;
		m_lifePanel.SetLifeTo (Health);
	}
		
	/// <summary>
	/// Hurt the specified damage. If life total is less than 1 the game will be lost.
	/// </summary>
	/// <param name="damage">Damage.</param>
	public void Hurt (int damage)
	{
		
		m_healthPoint = Mathf.Max (minHealth, Health - damage);
		m_lifePanel.SetLifeTo (Health);
		if (Health == 0) {
			GameManager.Instance ().Lost ();
		}
		m_speed = Mathf.Max (minSpeed, Speed - (float)damage);
	}
}
