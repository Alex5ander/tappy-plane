using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] GameObject[] stars;
    [SerializeField] float speedScale;
    [SerializeField] SpriteRenderer top;
    [SerializeField] SpriteRenderer bottom;
    Vector2 size;
    float w;
    void Awake()
    {
        Level level = GameManager.Instance.levels[GameManager.Instance.levelSelected];
        top.sprite = level.top;
        bottom.sprite = level.bottom;
    }

    // Start is called before the first frame update
    void Start()
    {
        size = top.bounds.size;
        w = Camera.main.ScreenToWorldPoint(new(Screen.width, Screen.height)).x;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (transform.position.x < -(w + size.x))
        {
            Vector3 pos = transform.position;
            pos.x = w + size.x;
            pos.y = Random.Range(-.75f, .75f);
            transform.position = pos;
            stars[Random.Range(0, stars.Length)].SetActive(true);
        }
        transform.position += GameManager.Instance.speed * speedScale * Time.fixedDeltaTime * Vector3.left;
    }
}
