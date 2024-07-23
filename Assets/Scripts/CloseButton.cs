using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public void OnClick() => GameManager.Instance.Close();
}
