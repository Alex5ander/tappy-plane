using UnityEngine;

[CreateAssetMenu]
public class Settings : ScriptableObject
{
    public RuntimeAnimatorController[] planes;
    public RuntimeAnimatorController[] previews;
    public Level[] levels;
    public float speed;
    public int planeSelected = 0;
    public int levelSelected = 0;

    public void ChangeLevel(int direction)
    {
        levelSelected += direction;
        levelSelected %= levels.Length;
        levelSelected = Mathf.Abs(levelSelected);
    }

    public void ChangePlane(int direction)
    {
        planeSelected += direction;
        planeSelected %= planes.Length;
        planeSelected = Mathf.Abs(planeSelected);
    }
}
