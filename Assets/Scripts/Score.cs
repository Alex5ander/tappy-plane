using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Image[] ScoreImages;
    [SerializeField] Sprite[] Numbers;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore()
    {
        char[] chars = GameManager.Instance.score.ToString().ToCharArray();
        Array.Reverse(chars);
        string text = new(chars);

        for (int i = 0; i < text.Length; i++)
        {
            int index = int.Parse(text[i].ToString());
            Sprite numberImage = Numbers[index];
            ScoreImages[i].sprite = numberImage;
            if (!ScoreImages[i].gameObject.activeSelf)
            {
                ScoreImages[i].gameObject.SetActive(true);
            }
        }
    }
}
