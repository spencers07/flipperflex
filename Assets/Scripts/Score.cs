using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;

    [SerializeField] TMP_Text textMeshPro;

    void Start()
    {
        UpdateText();
    }

    public void AddScore(int amount) 
    {
        score += amount;

        UpdateText();
    }

    private void UpdateText() 
    {
        textMeshPro.text = $"Score: {score}";
    }
}
