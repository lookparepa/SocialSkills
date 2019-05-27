using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentToGoogle : MonoBehaviour
{
    public GameObject name;
    public GameObject nickname;
    public GameObject endscore;

    private string Name;
    private string Nickname;
    private string EndScore;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLScnk4knEVI4bXXE4oJ89qCYJyc-6bPlUxHvzxYG7OGYwn9xuw/formResponse";

    IEnumerator Post(string name, string nickname, string endscore){
        WWWForm form = new WWWForm();
        form.AddField("entry.641518768", name);
        form.AddField("entry.559705182", nickname);
        form.AddField("entry.745646154", endscore);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }

    public void Send(){
        Name = name.GetComponent<InputField>().text;
        Nickname = nickname.GetComponent<InputField>().text;
        EndScore = endscore.GetComponent<InputField>().text;

        StartCoroutine(Post(Name, Nickname, EndScore));
    }
}
