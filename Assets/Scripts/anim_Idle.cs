using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_Idle : MonoBehaviour
{
    public Animator DuckIdleAnim;

    // Start is called before the first frame update
    void Start()
    {
        DuckIdleAnim = GetComponent<Animator>();
        DuckIdleAnim.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
