using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static void RestartGame()
    {
       SceneManager.LoadScene(0);
    }
}
