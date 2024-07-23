using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] Texture2D active;
    [SerializeField] Texture2D hover;
    [SerializeField] Rigidbody2D body;
    [SerializeField] float impulse;
    Animator animator;
    bool applyForce = false;
    [SerializeField] UnityEvent onAddScore;
    [SerializeField] UnityEvent onGameOver;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = GameManager.Instance.planes[GameManager.Instance.planeSelected];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && body.linearVelocity.y < 0)
        {
            applyForce = true;
        }
    }

    void FixedUpdate()
    {
        if (applyForce)
        {
            body.AddForceY(impulse, ForceMode2D.Impulse);
            applyForce = false;
        }
        animator.SetFloat("speedY", body.linearVelocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            onGameOver.Invoke();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        int score = 0;
        if (other.gameObject.name == "starBronze")
        {
            score = 1;
        }
        else if (other.gameObject.name == "starSilver")
        {
            score = 5;
        }
        else if (other.gameObject.name == "starGold")
        {
            score = 10;
        }
        if (score != 0)
        {
            GameManager.Instance.AddScore(score);
            onAddScore.Invoke();
            other.gameObject.SetActive(false);
        }
    }
}
