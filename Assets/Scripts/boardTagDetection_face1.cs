using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardTagDetection_face1 : MonoBehaviour
{
    bool face1_started;
    public LayerMask face_LayerMask;
    public Canvas Canvas1;

    // Start is called before the first frame update
    void Start()
    {
        face1_started = true;
    }

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TagDetection_Collisions();
    }

    void TagDetection_Collisions()
    {

        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity, face_LayerMask);
        int i = 0;

        while (i < hitColliders.Length)
        {

            //Debug.Log("Hit: " + hitColliders[i].name + i);
            i++;
        }
    }

    public void OnTriggerEnter()
    {
        Canvas1.enabled = false;
       
    }

}
