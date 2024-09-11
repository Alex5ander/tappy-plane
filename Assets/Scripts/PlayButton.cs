using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void OnClick() => GameManager.Instance.Play();
}
