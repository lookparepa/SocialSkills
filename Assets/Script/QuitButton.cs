using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    [SerializeField]
    private string EXCEL_URL = "https://docs.google.com/spreadsheets/d/1F-khBDrnF8aP3HXTOp5XNPLAdKyoqMYZhtA4ci24WBc/edit#gid=842434672";

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void GoUrl()
    {
        Debug.Log("GoURL!");
        Application.OpenURL(EXCEL_URL);
    }
}
