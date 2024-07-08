using UnityEngine;

public class Countdown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCountEnd()
    {
        GameManager.Instance.StartGame();
    }
}
