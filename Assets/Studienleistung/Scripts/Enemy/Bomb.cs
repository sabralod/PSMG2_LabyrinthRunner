using UnityEngine;
using System.Collections;

/// <summary>
/// Bomb.
/// </summary>
public class Bomb : MonoBehaviour
{
	private PlayerManager m_playerManager;

	private int m_damage;

	/// <summary>
	/// Gets or sets the damage.
	/// </summary>
	/// <value>The damage.</value>
	public int damage {
		get { return m_damage; }
		set { m_damage = value; }
	}

	/// <summary>
	/// Init the specified playerManager and damage.
	/// </summary>
	/// <param name="playerManager">Player manager.</param>
	/// <param name="damage">Damage.</param>
	public void Init (PlayerManager playerManager, int damage)
	{
		m_playerManager = playerManager;
		m_damage = damage;
	}
		
	/// <summary>
	/// Raises the trigger enter event. Hurt that player and destroy the bomb.
	/// </summary>
	/// <param name="collider">Collider.</param>
	void OnTriggerEnter (Collider collider)
	{
		m_playerManager.Hurt (damage);
		Destroy (gameObject);
	}
}
