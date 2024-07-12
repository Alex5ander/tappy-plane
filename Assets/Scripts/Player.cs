using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Settings settings;
    [SerializeField] Texture2D active;
    [SerializeField] Texture2D hover;
    [SerializeField] Rigidbody2D body;
    [SerializeField] float impulse;
    Animator animator;
    bool applyForce = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = settings.planes[settings.planeSelected];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && body.velocity.y < 0)
        {
            Cursor.SetCursor(active, Vector2.zero, CursorMode.Auto);
            applyForce = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(hover, Vector2.zero, CursorMode.Auto);
        }
    }

    void FixedUpdate()
    {
        if (applyForce)
        {
            body.AddForceY(impulse, ForceMode2D.Impulse);
            applyForce = false;
        }
        animator.SetFloat("speedY", body.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "starBronze")
        {
            GameManager.Instance.AddScore(1);
        }
        else if (other.gameObject.name == "starSilver")
        {
            GameManager.Instance.AddScore(5);
        }
        else if (other.gameObject.name == "starGold")
        {
            GameManager.Instance.AddScore(10);
        }

        other.gameObject.SetActive(false);
    }
}
