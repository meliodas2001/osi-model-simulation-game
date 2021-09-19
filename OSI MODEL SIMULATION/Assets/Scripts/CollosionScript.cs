using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollosionScript : MonoBehaviour
{
    private bool collided = false;

    public GameObject collider;
    public GameManager gm;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collided = true;
        //if collosin occour then run protocal corrosponding layer
        gm.runProtocol(this.getName());
        //de activate object after collosion
        gameObject.SetActive(false);
    }

    public bool isCollided()
    {
        return collided;
    }

    public string getName()
    {
        return collider.name;
    }
}
