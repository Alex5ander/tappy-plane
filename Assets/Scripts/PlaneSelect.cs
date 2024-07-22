using UnityEngine;

public class PlaneSelect : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Start()
    {
        animator.runtimeAnimatorController = GameManager.Instance.previews[GameManager.Instance.planeSelected];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Change(int direction)
    {
        GameManager.Instance.ChangePlane(direction);
        animator.runtimeAnimatorController = GameManager.Instance.previews[GameManager.Instance.planeSelected];
    }
}
