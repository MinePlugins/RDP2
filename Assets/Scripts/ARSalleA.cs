using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ARSalleA : MonoBehaviour, ITrackableEventHandler
{

    public TrackableBehaviour mTrackableBehaviour;
    public GameObject portal;
    public GameObject camera;
    private bool detected=false;
    // Start is called before the first frame update
    void Start()
    {
        mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(portal.transform.position, camera.transform.position);
        if(distance <= 20 && detected)
        {
            SceneManager.LoadScene("Enigme1", LoadSceneMode.Single);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            detected = true;
        }
        else
        {
            Debug.Log("NOLLOLL");

        }
    }
}
