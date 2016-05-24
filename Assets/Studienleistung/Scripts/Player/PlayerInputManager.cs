using UnityEngine;
using System.Collections;

/// <summary>
/// Player input manager.
/// </summary>
public class PlayerInputManager : MonoBehaviour
{
	
	private string m_inputMovementAxisName = "Vertical";
	private string m_inputRotationAxisName = "Horizontal";

	private float m_inputMovement;
	private float m_inputRotation;

	private Rigidbody m_rigidbody;

	private PlayerManager m_playerManager;

	/// <summary>
	/// Move this instance.
	/// </summary>
	private void Move ()
	{
		m_inputMovement = Input.GetAxis (m_inputMovementAxisName);
		Vector3 movement = transform.forward * m_playerManager.Speed * m_inputMovement * Time.deltaTime;
		m_rigidbody.MovePosition (m_rigidbody.position + movement);
	}
		
	/// <summary>
	/// Rotate this instance.
	/// </summary>
	private void Rotate ()
	{
		m_inputRotation = Input.GetAxis (m_inputRotationAxisName);
		float turn = m_inputRotation * (m_playerManager.Speed / 2);
		Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f);
		m_rigidbody.MoveRotation (m_rigidbody.rotation * turnRotation);

	}

	/// <summary>
	/// Fixeds the update.
	/// </summary>
	void FixedUpdate ()
	{
		Move ();
		Rotate ();
	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start ()
	{
		m_rigidbody = GetComponent<Rigidbody> ();
		m_playerManager = gameObject.GetComponent<PlayerManager> ();
	}
}
