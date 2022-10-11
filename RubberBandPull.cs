using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberBandPull : MonoBehaviour
{
    private LineRenderer line;
    List<Vector3> linePts;
    Vector3 rightArm = new Vector3(-10.6f, -6, 1.75f);
    Vector3 leftArm = new Vector3(-9.6f, -6, -1.75f);
    //Vector3 leftArm = new Vector3(.5f, 4, -1.75f);
    //Vector3 rightArm = new Vector3(.4f, 4, 1.75f);

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        linePts = new List<Vector3>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Slingshot.aimingMode)
        {
            
            Vector3 mousePos3D = Slingshot.projectile.transform.position;

            line.enabled = true;

            if (linePts.Count == 0)
            {
                linePts.Add(leftArm);

                line.positionCount = 1;
                line.SetPosition(0, linePts[0]);
            }

            linePts.Insert(1, mousePos3D );
            linePts.Insert(2, rightArm);
            line.positionCount = 3;
            line.SetPosition(1, linePts[1]);
            line.SetPosition(2, linePts[2]);
        }

        else if(!Slingshot.aimingMode)
        {
            linePts = new List<Vector3>();
            line.enabled = false;
        }
    }
}
