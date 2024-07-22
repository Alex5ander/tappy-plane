using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public void Close() => GameManager.Instance.Close();
}
