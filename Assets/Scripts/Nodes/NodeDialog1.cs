using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeDialog1 : MonoBehaviour {
   
    public GameObject panel1;
    private Node1 temp;
    public void Show(Node1 node)
    {
        panel1.SetActive(true);
        temp = node;
    }

    public void Build(string txt)
    {
        panel1.SetActive(false);
        temp.Build(txt);
    }
}
