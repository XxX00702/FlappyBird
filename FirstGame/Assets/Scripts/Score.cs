using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instanse;
    [SerializeField] private TextMeshProUGUI scoreT;
    private int _score;
    
    private void Start()
    {
        Instanse = this;
    }

    public void SetScore(int score)
    {
        this._score += score;
        scoreT.text = "Score: "  + this._score.ToString();
    }
}
