using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRend : MonoBehaviour
{
    [Range(0, 10)]
    public float slider = 0f;

    
    public Vector3 CubeSize = Vector3.zero;

    private void Awake()
    {

       


    }

    private void OnDrawGizmos()
    {
        //// Display the explosion radius when selected
        //Gizmos.color = new Color(1, 1, 0, 0.75F);
        //Gizmos.DrawSphere(transform.position, explosionRadius);

       CubeSize = new Vector3(slider, slider, slider);


        Gizmos.color = new Color(1, 0, 1, 1);
        Gizmos.DrawCube(transform.position, CubeSize);
    }

}
