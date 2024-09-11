using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] float speedScale;
    [SerializeField] SpriteRenderer sprite;
    Vector2 size;
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
        if (transform.position.x < -size.x / 2)
        {
            transform.position = new(0, transform.position.y);
        }
        transform.position += GameManager.Instance.speed * speedScale * Time.fixedDeltaTime * Vector3.left;
    }
}
