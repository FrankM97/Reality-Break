using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopMenuMusic : MonoBehaviour
{
    void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("MenuMusic");
        Destroy(A);
    }
}
