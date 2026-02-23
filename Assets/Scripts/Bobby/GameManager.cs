// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GameManager : MonoBehaviour
// {
//     public enum GameState
//     {
//         Start,
//         Playing,
//         Paused,
//         GameOver
//     }

//     public GameState currentState = GameState.Start;
//     public GameObject gameOverPanel;
    
//     public void StartGame()
//     {
//         currentState = GameState.Playing;
//         Debug.Log("Game Started");
//     }

//     public void PauseGame()
//     {
//         currentState = GameState.Paused;
//         Debug.Log("Game Paused");
//     }

//     public void EndGame()
//     {
//         currentState = GameState.GameOver;
//         Debug.Log("Game Over");
//         if (gameOverPanel != null)
//             gameOverPanel.SetActive(true);
//     }
// }
