using UnityEngine;
using System.Collections;

public class DanceManager : MonoBehaviour {

    bool startCount = false;
    float startTime = 0.0f;
    public GameObject fee;
    public GameObject chimer;
    public GameObject ange;
    public GameObject homonculus;


    // Use this for initialization
    void Start () {

        startCount = true;
        startTime = Time.time;

        fee.SetActive(false);
        chimer.SetActive(false);
        ange.SetActive(false);
        homonculus.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {

        if (startCount)
        {
            if (startTime + 1.0f < Time.time)
            {
                fee.SetActive(true);
            }

            if (startTime + 3.0f < Time.time)
            {
                chimer.SetActive(true);
            }

            if (startTime + 4.5f < Time.time)
            {
                ange.SetActive(true);
            }

            if (startTime + 6.0f < Time.time)
            {
                homonculus.SetActive(true);
            }

            if (startTime + 166.0f < Time.time)
            {
                Application.LoadLevel("Fin");
            }
        }

    }
}
