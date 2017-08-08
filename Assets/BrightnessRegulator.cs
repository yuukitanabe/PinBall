using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour {

    Material myMaterial;


    private float minEmisshon = 0.3f;

    private float magEmission = 2.0f;

    private int degree = 0;

    private int speed = 10;

    Color defaoultColor = Color.white;




	// Use this for initialization
	void Start () {
		
        if (tag == "SmallStarTag")
        {
            this.defaoultColor = Color.white;
       
        }
        else if (tag == "LargeStarTag")
        {
            this.defaoultColor = Color.yellow;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.defaoultColor = Color.blue;
        }

        this.myMaterial = GetComponent<Renderer>().material;

        myMaterial.SetColor("_EmissionColor", this.defaoultColor * minEmisshon);
	}
	
	// Update is called once per frame
	void Update () {
		
        if ( this.degree >= 0)
        {
            Color emissionColor = this.defaoultColor * (this.minEmisshon + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);


            myMaterial.SetColor("_EmissionColor", emissionColor);


            this.degree -= this.speed;
        }
	}

    void OnCollisionEnter(Collision other)
    {
        this.degree = 180;
    }
}
