using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layers : MonoBehaviour
{
    public Dialogue[] dialogue;
    public DialogueManager dialogueManager;
    //cant use constructor on a class inhereated by monobehaviour so instead using awake function in child script to set below value
    protected int layerIndex;
    // Start is called before the first frame update

    public void sayHello()
    {
        Debug.Log("hello");
    }

    public void runProtocal()
    {
        if(GameManager.visitedLayerMask[layerIndex]==0)
        {
            forwardProtocal();
            GameManager.visitedLayerMask[layerIndex] = 1;
        }
        else
        {
            reverseProtocal();
        }
    }
    public virtual void forwardProtocal()
    {

    }

    public virtual void reverseProtocal()
    {

    }
}
