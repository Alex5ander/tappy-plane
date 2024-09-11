using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] float speedScale;
    Vector2 size;
    [SerializeField] SpriteRenderer[] spriteRenderers;

    void Awake()
    {
        Level level = GameManager.Instance.levels[GameManager.Instance.levelSelected];
        foreach (SpriteRenderer spriteRenderer in spriteRenderers)
        {
            spriteRenderer.sprite = level.ground;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        size = spriteRenderers[0].bounds.extents;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (transform.position.x < -size.x * 2)
        {
            transform.position = Vector3.zero;
        }
        transform.position += GameManager.Instance.speed * speedScale * Time.fixedDeltaTime * Vector3.left;
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(new(transform.position.x, -5f), new(transform.position.x, 5));
    }

}
