using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Texture2D cursorActive;
    [SerializeField] Texture2D cursorInactive;
    public RuntimeAnimatorController[] planes;
    public RuntimeAnimatorController[] previews;
    public Level[] levels;
    public float speed;
    public int planeSelected = 0;
    public int levelSelected = 0;
    public int score;
    public static GameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(cursorActive, Vector2.zero, CursorMode.Auto);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(cursorInactive, Vector2.zero, CursorMode.Auto);
        }
    }

    public void AddScore(int score)
    {
        this.score += score;
        speed += 0.25f;
    }

    public void Close()
    {
        Time.timeScale = 1;
        score = 0;
        speed = 5;
        SceneManager.LoadScene(0);
    }

    public void ChangeLevel(int direction)
    {
        levelSelected += direction;
        levelSelected = levelSelected > levels.Length - 1 ? 0 : levelSelected < 0 ? levels.Length - 1 : levelSelected;
    }

    public void ChangePlane(int direction)
    {
        planeSelected += direction;
        planeSelected = planeSelected > planes.Length - 1 ? 0 : planeSelected < 0 ? planes.Length - 1 : planeSelected;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
