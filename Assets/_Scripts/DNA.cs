using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Collider2D))]
public class DNA : MonoBehaviour 
{
    //Gene for color
    public float r;
    public float g;
    public float b;
    public float s;

    public float timeToDie = 0;

    SpriteRenderer sRenderer;
    Collider2D sCollider;

    bool dead = false;

	// Use this for initialization
	void Start () 
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, g, b);
        this.transform.localScale = new Vector3(s, s, s);
	}

    private void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        Debug.Log("Dead at = "+timeToDie);
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }

    // Update is called once per frame
    void Update () 
    {
		
	}
}
