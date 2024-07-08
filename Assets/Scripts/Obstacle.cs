using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] GameObject[] stars;
    [SerializeField] float speedScale;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position += GameManager.Instance.speed * speedScale * Time.fixedDeltaTime * Vector3.left;
        if (transform.position.x < -4.5f * 2)
        {
            Vector3 pos = transform.position;
            float worldWidth = Camera.main.ScreenToWorldPoint(new(Screen.width, 0)).x;
            pos.x = worldWidth;
            pos.y = Random.Range(-.75f, .75f);
            transform.position = pos;
            stars[Random.Range(0, stars.Length)].SetActive(true);
        }
    }
}
