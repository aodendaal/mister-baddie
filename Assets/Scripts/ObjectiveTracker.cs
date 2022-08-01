using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectiveTracker : MonoBehaviour
{
    public static ObjectiveTracker Instance;

    [SerializeField] private Transform objectivePrefab;
    [SerializeField] private TextMeshProUGUI scoreText;

    private int total = 0;
    private int score = 0;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        var spawnPoints = GameObject.FindObjectsOfType<ObjectiveMarker>();

        foreach (var spawnPoint in spawnPoints)
        {
            Instantiate(objectivePrefab, spawnPoint.transform.position, Quaternion.identity);
        }

        total = spawnPoints.Length;
        DrawScore();
    }

    public void UpdateScore()
    {
        score++;
        DrawScore();
        Debug.Log(score);
    }

    private void DrawScore()
    {
        scoreText.text = $"Found: {score}/{total}";
    }
}
