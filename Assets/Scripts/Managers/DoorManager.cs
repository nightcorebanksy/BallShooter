using UnityEngine;

// Dynae Starratt
// 2024
// This work is licensed under CC BY-NC-SA 4.0 (https://creativecommons.org/licenses/by-nc-sa/4.0/)

public class DoorManager : MonoBehaviour
{

	[Header("References")]
	public GameObject ball;  // Ball Mesh?
	public Rigidbody rb_ball;
	public GameObject door;

	[Header("Script References")]
    public GameStateManager _gameStateManager;
    public BallManager _ballManager;
    public LevelManager _levelManager;
    public UIManager _uIManager;

	public bool doorOpened;
	public float doorOpenSpeed = 0.5f;



}
