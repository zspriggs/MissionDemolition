using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PrevProjectileLine : MonoBehaviour
{ 
  // public static LineRenderer line;

    [Header("Set in Inspector")]
    private static LineRenderer thisLine;


    // Start is called before the first frame update
    void Start()
    {
        thisLine = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    

    }


    public static void DestroyOld()
    {
        thisLine.positionCount = 0;
        thisLine.enabled = false;
    }

    public static void Populate(Vector3 pt)
    {
        thisLine.positionCount++;
        thisLine.SetPosition(thisLine.positionCount - 1, pt);
        thisLine.enabled = true;
    }

    public static void Fixup()
    {
        thisLine.SetPosition(0, thisLine.GetPosition(1));
       // thisLine.positionCount -= 10;
    }

}
