using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void selectScene(){
        switch (this.gameObject.name){
        case "Lv1Button":
            SceneManager.LoadScene ("Lv1");
            break;
        case "Lv2Button":
            SceneManager.LoadScene ("Lv2");
            break;
        case "Lv3Button":
            SceneManager.LoadScene ("Lv3");
            break;
        case "Lv4Button":
            SceneManager.LoadScene ("Lv4");
            break;
        case "Lv5Button":
            SceneManager.LoadScene ("Lv5");
            break;
        case "Lv6Button":
            SceneManager.LoadScene ("Lv6");
            break;
        case "Lv7Button":
            SceneManager.LoadScene ("Lv7");
            break;
        case "Lv8Button":
            SceneManager.LoadScene ("Lv8");
            break;
        case "Lv9Button":
            SceneManager.LoadScene ("Lv9");
            break;
        case "Lv10Button":
            SceneManager.LoadScene ("Lv10");
            break;

        case "GoLv2":
            SceneManager.LoadScene ("Lv2");
            break;
        case "GoLv3":
            SceneManager.LoadScene ("Lv3");
            break;
        case "GoLv4":
            SceneManager.LoadScene ("Lv4");
            break;
        case "GoLv5":
            SceneManager.LoadScene ("Lv5");
            break;
        case "GoLv6":
            SceneManager.LoadScene ("Lv6");
            break;
        case "GoLv7":
            SceneManager.LoadScene ("Lv7");
            break;
        case "GoLv8":
            SceneManager.LoadScene ("Lv8");
            break;
        case "GoLv9":
            SceneManager.LoadScene ("Lv9");
            break;
        case "GoLv10":
            SceneManager.LoadScene ("Lv10");
            break;
        case "End":
            SceneManager.LoadScene ("End");
            break;
        }
    }
}
