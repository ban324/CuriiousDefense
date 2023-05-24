using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject InGamePanel;
    [SerializeField]
    GameObject MainMenuPanel;

    public void InGamePanelOnOff()
    {
        InGamePanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }
    public void MainMenuPanelOnOff()
    {
        MainMenuPanel.SetActive(true);
        InGamePanel.SetActive(false);

    }
}
