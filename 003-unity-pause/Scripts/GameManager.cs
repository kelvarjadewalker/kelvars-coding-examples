using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool IsPaused { get; private set; }
    
    [SerializeField] private UIManager uiManager;

    private void Start()
    {
        IsPaused = false;
        Time.timeScale = 1;
    }

    public void TogglePause()
    {
        IsPaused = !IsPaused;
        Time.timeScale = IsPaused ? 0f : 1f;
        uiManager.DisplayPauseScreen(IsPaused);
    }
}
