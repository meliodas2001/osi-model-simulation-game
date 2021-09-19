using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue


{
    
    public string pName;
    [TextArea(3,10)]
    public string dialogue;
    // Start is called before the first frame update
    public void setName(string pName)
    {
        this.pName = pName;
    }
    public void setDialogue(string dialogue)
    {
        this.dialogue = dialogue;
    }

    public string getName()
    {
        return pName;
    }

    public string getDialogue()
    {
        return dialogue;
    }

}



