using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endTrigger : MonoBehaviour
{
    public GameObject endUI;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("StartScene");
    }
}
