using UnityEngine;
using UnityEngine.Events;

public class Countdown : MonoBehaviour
{
    [SerializeField] UnityEvent onStart;
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
        onStart.Invoke();
    }
}
