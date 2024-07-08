using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] float speedScale;
    [SerializeField] SpriteRenderer sprite;
    Vector2 size;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        size = sprite.bounds.extents;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position += GameManager.Instance.speed * speedScale * Time.fixedDeltaTime * Vector3.left;
        if (transform.position.x < -size.x * 2)
        {
            transform.position = Vector2.zero;
        }
    }
}
