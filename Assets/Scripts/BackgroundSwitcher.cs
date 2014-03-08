using UnityEngine;
using System.Collections;

public class BackgroundSwitcher : MonoBehaviour {

    private Sprite preSprite;

	// Use this for initialization
	void Start ()
    {
        preSprite = Resources.Load<Sprite>("bg2");
	}
	
	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            var t = GetComponent<SpriteRenderer>().sprite;
            GetComponent<SpriteRenderer>().sprite = preSprite;
            preSprite = t;
        }
        
	}
}
