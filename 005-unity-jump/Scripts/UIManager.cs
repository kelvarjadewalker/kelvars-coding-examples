using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pauseText;

    private void Start()
    {
        DisplayPauseScreen(false);
    }

    public void DisplayPauseScreen(bool show)
    {
        pauseText.gameObject.SetActive(show);
    }

}
