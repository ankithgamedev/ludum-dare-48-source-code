using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public GameObject score_tracker;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        score_tracker.GetComponent<ScoreSystem>();
        
    }
    private void Update()
    {
        Cursor.visible = true;
        score_tracker.active = false;
    }
}
