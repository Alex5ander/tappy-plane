using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    [SerializeField] Texture2D hover;
    [SerializeField] Texture2D active;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(hover, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(active, Vector2.zero, CursorMode.Auto);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(hover, Vector2.zero, CursorMode.Auto);
        }
    }

    public void OnPlayClick()
    {
        SceneManager.LoadScene(1);
    }
}
