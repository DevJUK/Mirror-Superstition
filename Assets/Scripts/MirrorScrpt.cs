using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorScrpt : MonoBehaviour
{
    public bool Broken;
	public Material BrokenText;
    public AudioManager AudioManager;
	private bool IsCoRunning;

    // Update is called once per frame
    void Update()
    {
        if (Broken)
        {
            AudioManager.PlayClip(2, 1, 1);
            foreach (Renderer G in GetComponentsInChildren<Renderer>())
			{
				if (G.gameObject.name == "Mirror")
				{
					G.material = BrokenText;

					if (!IsCoRunning)
					{
						StartCoroutine(RemoveMirror(G.gameObject.transform.parent.gameObject));
					}
				}
			}
        }
    }


	public IEnumerator RemoveMirror(GameObject Mirror)
	{
		IsCoRunning = true;
		yield return new WaitForSeconds(1);
		Destroy(Mirror, .1f);
	}
}