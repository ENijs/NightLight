using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    //MouseTracking
    private Vector3 mousePosition;

    //LightOverTime
    public bool LightDecreasebool;
    private Light lighting;
    public float lightingDecrease;
    public float startIntensityAndRange;

    // Use this for initialization
    void Start () {

        //Get Light
        lighting = GetComponent<Light>();
        lighting.intensity = startIntensityAndRange;
    }
	
	// Update is called once per frame
	void Update () {
        MouseTracking();
        IntensityOverTime();
    }

    void MouseTracking(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(mousePosition.x - 0.2f, mousePosition.y, this.transform.position.z);
    }




    void IntensityOverTime(){
        if (LightDecreasebool == true) {
            lighting.intensity = lighting.intensity - lightingDecrease/1000;
            lighting.range = lighting.intensity;
            //Debug.Log("lightIntensity =" + lighting.intensity);
        }  
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        lighting.intensity = startIntensityAndRange;
        Debug.Log("Triggerd intesity");
    }
}
