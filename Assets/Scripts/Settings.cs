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
        levelSelected = levelSelected > levels.Length - 1 ? 0 : levelSelected < 0 ? levels.Length - 1 : levelSelected;
    }

    public void ChangePlane(int direction)
    {
        planeSelected += direction;
        planeSelected = planeSelected > planes.Length - 1 ? 0 : planeSelected < 0 ? planes.Length - 1 : planeSelected;
    }
}
