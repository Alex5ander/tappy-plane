using System;
using UnityEngine;


[Serializable]
public class Level
{
    public Sprite ground;
    public Sprite top;
    public Sprite bottom;
}

public class LevelSelect : MonoBehaviour
{
    [SerializeField] SpriteRenderer ground;
    // Start is called before the first frame update
    void Start()
    {
        ground.sprite = GameManager.Instance.levels[GameManager.Instance.levelSelected].ground;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Change(int direction)
    {
        GameManager.Instance.ChangeLevel(direction);
        ground.sprite = GameManager.Instance.levels[GameManager.Instance.levelSelected].ground;
    }
}
