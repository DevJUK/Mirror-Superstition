using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBreakScrpt : MonoBehaviour
{
    public float Range;
    public MirrorScrpt MirrorScrpt;
    public AudioManager AudioManager;

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

			if (Input.GetButtonDown("P1Attack") && gameObject.tag == "P1")
			{
				GetComponentInChildren<Animator>().SetTrigger("Punch");
				Hit.transform.GetComponent<MirrorScrpt>().Broken = true;
                AudioManager.PlayClip(0,1,1);
			}
			else if (Input.GetButtonDown("P2Attack") && gameObject.tag == "P2")
			{
				GetComponentInChildren<Animator>().SetTrigger("Punch");
				Hit.transform.GetComponent<MirrorScrpt>().Broken = true;
                AudioManager.PlayClip(0, 1, 1);
            }
			else if (Input.GetButtonDown("P3Attack") && gameObject.tag == "P3")
			{
				GetComponentInChildren<Animator>().SetTrigger("Punch");
				Hit.transform.GetComponent<MirrorScrpt>().Broken = true;
                AudioManager.PlayClip(0, 1, 1);
            }
		}
        else
        {
			if (Input.GetButtonDown("P1Attack") && gameObject.tag == "P1")
			{
				GetComponentInChildren<Animator>().SetTrigger("Punch");
                AudioManager.PlayClip(1, 1, 1);
            }
			else if (Input.GetButtonDown("P2Attack") && gameObject.tag == "P2")
			{
				GetComponentInChildren<Animator>().SetTrigger("Punch");
                AudioManager.PlayClip(1, 1, 1);
            }
			else if (Input.GetButtonDown("P3Attack") && gameObject.tag == "P3")
			{
				GetComponentInChildren<Animator>().SetTrigger("Punch");
                AudioManager.PlayClip(1, 1, 1);
            }
		}
    }
}
