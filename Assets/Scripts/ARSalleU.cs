using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ARSalleU : MonoBehaviour, ITrackableEventHandler
{

    public TrackableBehaviour mTrackableBehaviour;
    private EnigmeManager instance;
    private bool isUsed = false;
    // Start is called before the first frame update
    void Start()
    {
        instance = new EnigmeManager();
        mTrackableBehaviour.RegisterTrackableEventHandler(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            if (isUsed)
            {
                instance.UpScore(100);
            }
        }
        else
        {
            Debug.Log("NOLLOLL");

        }
    }
}
