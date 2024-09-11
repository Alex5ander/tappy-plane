using UnityEngine;

public class Medal : MonoBehaviour
{
    [SerializeField] GameObject Bronze;
    [SerializeField] GameObject Silver;
    [SerializeField] GameObject Gold;

    void Awake()
    {
        if (GameManager.Instance.score > 100)
        {
            Gold.SetActive(true);
        }
        else if (GameManager.Instance.score > 50)
        {
            Silver.SetActive(true);
        }
        else
        {
            Bronze.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
