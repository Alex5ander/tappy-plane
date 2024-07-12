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
    [SerializeField] Settings settings;
    [SerializeField] SpriteRenderer ground;
    // Start is called before the first frame update
    void Start()
    {
        ground.sprite = settings.levels[settings.levelSelected].ground;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Change(int direction)
    {
        settings.ChangeLevel(direction);
        ground.sprite = settings.levels[settings.levelSelected].ground;
    }
}
