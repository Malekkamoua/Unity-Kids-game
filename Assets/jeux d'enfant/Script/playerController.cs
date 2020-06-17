using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public AudioSource carSound;
    
    void Start()
    {
        carSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
        
            gameObject.transform.Translate(0, 0, 0.5f);
            carSound.Play();

        }


    }

