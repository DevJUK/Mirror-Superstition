using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBreakScrpt : MonoBehaviour
{
    public float Range;
    public MirrorScrpt MirrorScrpt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position,transform.forward, out Hit, Range))
        {
            if (Input.GetButtonDown("Interact"))
            {
				GetComponentInChildren<Animator>().SetTrigger("Punch");
				Hit.transform.GetComponent<MirrorScrpt>().Broken = true;
            }
        }
        else
        {
            if (Input.GetButtonDown("Interact"))
            {
				GetComponentInChildren<Animator>().SetTrigger("Punch");
			}
        }
    }
}
