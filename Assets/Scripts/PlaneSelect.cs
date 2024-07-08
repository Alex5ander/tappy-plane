using UnityEngine;

public class PlaneSelect : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AnimatorOverrideController[] animatorOverrideControllers;
    public static int selected = 0;
    void Start()
    {
        selected = selected < 0 ? animatorOverrideControllers.Length - 1 : selected;
        animator.runtimeAnimatorController = animatorOverrideControllers[selected];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnArrowLeftClick()
    {
        selected -= 1;
        selected = selected < 0 ? animatorOverrideControllers.Length - 1 : selected;
        animator.runtimeAnimatorController = animatorOverrideControllers[selected];
    }

    public void OnArrowRightClick()
    {
        selected += 1;
        selected = selected > animatorOverrideControllers.Length - 1 ? 0 : selected;
        animator.runtimeAnimatorController = animatorOverrideControllers[selected];
    }
}
