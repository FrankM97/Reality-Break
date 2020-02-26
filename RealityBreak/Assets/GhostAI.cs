using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostAI : MonoBehaviour
{
    GameObject cameraGameObject;
    IEnumerator coroutine;

    public string FindTag = "MainCamera";
    public float TeleportationFrequency = 6f;
    public float TeleportationDistance = 10f;
    public Image PopupImage;
    public int IgnoreLayer = 2;

    // Start is called before the first frame update
    void Start()
    {
        cameraGameObject = GameObject.FindGameObjectWithTag(FindTag);
        coroutine = TeleportTimer(TeleportationFrequency);
        StartCoroutine(coroutine);

    }

    // Update is called once per frame
    void Update()
    {
        //if there is a collider intersecting the line
        if (Physics.Linecast(transform.position, cameraGameObject.transform.position /*, (1 << IgnoreLayer)*/))
            UndoTheSpookyThing();
        else
            DoTheSpookyThing();

        transform.Translate(Vector3.up * 0.02f);
    }
    private IEnumerator TeleportTimer(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            gameObject.transform.position = new Vector3(cameraGameObject.transform.position.x + TeleportationDistance * UnityEngine.Random.Range(-1f, 1f), cameraGameObject.transform.position.y - 10, cameraGameObject.transform.position.z + TeleportationDistance * UnityEngine.Random.Range(-1f, 1f));
        }
    }

    void DoTheSpookyThing()
    {
        PopupImage.enabled = true;
    }

    void UndoTheSpookyThing()
    {
        PopupImage.enabled = false;
    }

}
