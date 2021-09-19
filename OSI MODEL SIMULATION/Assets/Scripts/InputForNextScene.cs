using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class InputForNextScene : MonoBehaviour

{
    public TextMeshProUGUI usernameInputField;
    public Button startButton;
    public static string username;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        setUsername();
    }
    public void OnClickOfStart()
    {
        // if username is empty do not switch scene ,
        //for some weired reason length of string in input field is greater by one than expected ,ex length of empty string is one
        if (username.Length == 1|| username.Length == 2)
            Debug.Log(username.Length);
        else
        SceneManager.LoadScene("PlayScene");
    }

    // call back after changing input field of username
    public void setUsername()
    {
        username = usernameInputField.text;
    }


}
