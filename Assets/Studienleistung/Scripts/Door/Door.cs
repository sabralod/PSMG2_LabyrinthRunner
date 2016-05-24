using UnityEngine;
using UnityEngine.Events;
using System.Collections;

/// <summary>
/// Door: Represents a door. Listen to the click event of open button, to open the door.
/// </summary>
public class Door : MonoBehaviour
{
	private bool m_open;
	private UnityAction m_openDoorAction;
	private Animator m_anim;
	private int m_count;

	/// <summary>
	/// Gets a value indicating whether this <see cref="Door"/> is open.
	/// </summary>
	/// <value><c>true</c> if is open; otherwise, <c>false</c>.</value>
	public bool isOpen {
		get { return m_open; }
		private set { m_open = value; }
	}

	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake ()
	{
		isOpen = false;
		m_openDoorAction = new UnityAction (OpenDoor);
		m_anim = GetComponent<Animator> ();
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update ()
	{
		m_anim.SetBool ("Open", m_open);
	}

	public void OpenDoor ()
	{
		isOpen = true;
	}

	public void CloseDoor ()
	{
		isOpen = false;
	}
}
