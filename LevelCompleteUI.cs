using UnityEngine;
using TMPro;

public class LevelCompleteUI : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;          // the box that appears

    [SerializeField]
    private TextMeshProUGUI messageText;

    void Start()
    {
        if (panel != null)
            panel.SetActive(false);
    }

    public void Show()
    {
        if (panel == null) return;

        panel.SetActive(true);

        if (messageText != null)
            messageText.text = "Level Complete!";
    }
}