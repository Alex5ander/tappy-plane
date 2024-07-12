using UnityEngine;

public class PlaneSelect : MonoBehaviour
{
    [SerializeField] Settings settings;
    [SerializeField] Animator animator;
    void Start()
    {
        animator.runtimeAnimatorController = settings.previews[settings.planeSelected];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Change(int direction)
    {
        settings.ChangePlane(direction);
        animator.runtimeAnimatorController = settings.previews[settings.planeSelected];
    }
}
