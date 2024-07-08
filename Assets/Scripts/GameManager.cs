using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UnityEvent onStartGame;
    [SerializeField] UnityEvent onGameOver;
    [SerializeField] UnityEvent onAddScore;
    public float speed;
    public int score;
    public static GameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        onStartGame.Invoke();
    }

    public void GameOver()
    {
        onGameOver.Invoke();
        Time.timeScale = 0;
    }

    public void AddScore(int score)
    {
        this.score += score;
        speed += 0.25f;
        onAddScore.Invoke();
    }

    public void Close()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
