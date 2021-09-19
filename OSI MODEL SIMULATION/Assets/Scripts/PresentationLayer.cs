using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class PresentationLayer : Layers
{
    public GameObject player;
    public GameManager gm;
    private void Awake()
    {
        layerIndex = 1;
    }
    public override void forwardProtocal()
    {
        gm.setDisplayName(strToBinary(gm.getUserName()));
        shrinkSize();
        gm.changeColor(GameManager.encryptColor);
        dialogueManager.setDialogues(dialogue);
        dialogueManager.startDialogueSystem();
    }

    public override void reverseProtocal()
    {
        increaseSize();
        gm.changeColor(GameManager.originalColor);
        gm.setDisplayName(gm.getUserName());

    }

    string strToBinary(string s)
    {
        int n = s.Length;
        string ans = "";
        //running loop for one less than the string length as inputtext fiels for a wired reason has one extra character in it bu default
        for (int i = 0; i < n-1; i++)
        {
            // convert each char to
            // ASCII value
            int val = s[i];

            // Convert ASCII value to binary
            string bin = "";
            while (val > 0)
            {
                if (val % 2 == 1)
                {
                    bin += '1';
                }
                else
                    bin += '0';
                val /= 2;
            }
            bin = reverseString(bin);
            ans = bin + ans;
        }
        return ans;
    }
    string reverseString(string input)
    {
        char[] a = input.ToCharArray();
        int l, r = 0;
        r = a.Length - 1;

        for (l = 0; l < r; l++, r--)
        {
            // Swap values of l and r
            char temp = a[l];
            a[l] = a[r];
            a[r] = temp;
        }
        return string.Join("", a);
    }
    public void shrinkSize()
    {
        Vector3 decreaseScale = new Vector3(0.1f, 0.1f, 0.1f);
        player.transform.localScale -= decreaseScale;
    }

    public void increaseSize()
    {
        Vector3 increaseScale = new Vector3(0.1f, 0.1f, 0.1f);
        player.transform.localScale += increaseScale;
    }

}
