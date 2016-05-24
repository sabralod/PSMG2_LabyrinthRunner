using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/// <summary>
/// Game manager. Main entry point.
/// </summary>
public class GameManager : MonoBehaviour
{

	private static GameManager m_gameManager;

	public Transform spawnPoint;
	public GameObject prefabPlayer;

	public Transform[] bombSpawnPoints = new Transform[4];
	public GameObject prefabBomb;

	public int maxBombDamage = 4;
	public int minBombDamage = 1;

	private Bomb[] m_bombs;

	/// <summary>
	/// Gets the bomb references.
	/// </summary>
	/// <value>The bomb references.</value>
	public Bomb[] BombReferences {
		get {
			return m_bombs; 
		}

		private set {
			m_bombs = value; 
		}
	}
		
	/// <summary>
	/// Instance this instance.
	/// </summary>
	public static GameManager Instance ()
	{
		if (!m_gameManager) {
			m_gameManager = FindObjectOfType (typeof(GameManager)) as GameManager;
			if (!m_gameManager) {
				Debug.Log ("Game Manager Error!");
			}
		}

		return m_gameManager;
	}

	/// <summary>
	/// Avake this instance.
	/// </summary>
	void Avake ()
	{
		m_gameManager = GameManager.Instance ();
	}
		
	/// <summary>
	/// Raises the enable event.
	/// </summary>
	public void OnEnable ()
	{
		GameObject player = Instantiate (prefabPlayer, spawnPoint.position, spawnPoint.rotation) as GameObject;

		m_bombs = new Bomb[bombSpawnPoints.Length];

		for (int i = 0; i < bombSpawnPoints.Length; i++) {
			GameObject tmpBombObj = Instantiate (prefabBomb, bombSpawnPoints [i].position, bombSpawnPoints [i].rotation) as GameObject;
			tmpBombObj.name = "Bomb" + i;
			m_bombs [i] = tmpBombObj.GetComponent<Bomb> ();
			m_bombs [i].Init (player.GetComponent<PlayerManager> (), Random.Range (minBombDamage, maxBombDamage));
		}

	}
		
	/// <summary>
	/// Wait the specified time.
	/// </summary>
	/// <param name="time">Time.</param>
	IEnumerator Wait (float time)
	{
		Debug.Log ("Start waiting at: " + Time.time);
		yield return new WaitForSeconds (time);
		Time.timeScale = 0;
		Debug.Log ("Stop waiting at: " + Time.time);
	}
		
	/// <summary>
	/// Won this instance.
	/// </summary>
	public void Won ()
	{
		StartCoroutine (Wait (5f));
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
		
	/// <summary>
	/// Lost this instance.
	/// </summary>
	public void Lost ()
	{
		StartCoroutine (Wait (5f));
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
