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

    [SerializeField]
    GameObject SettingPanel;

    public void InGamePanelOn()
    {
        if(MainMenuPanel)
        {
            MainMenuPanel.SetActive(false);
        }
        if(SettingPanel)
        {
            SettingPanel.SetActive(false);
        }
            InGamePanel.SetActive(true);
    }
    public void MainMenuPanelOn()
    {
        MainMenuPanel.SetActive(true);
        if(InGamePanel)
        {
            InGamePanel.SetActive(false);
        }

    }
    public void SettingPanelOn()
    {   
        
        SettingPanel.SetActive(true);
        
        if(MainMenuPanel)
        {
            MainMenuPanel.SetActive(false);
        }
    }

}
