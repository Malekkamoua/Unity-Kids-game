using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Slider audio;
    public GameObject menuu;
    public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<AudioSource>().volume = audio.value;
    }

    public void menu()
    {
        Application.LoadLevel(0);

    }
    public void quit()
    {
        Application.Quit();

    }
    public void restart()
    {
        Application.LoadLevel(1);
    }
    public void Sound()
    {
        menuu.SetActive(false);
        sound.SetActive(true);
    }
    public void back_sound()
    {

        menuu.SetActive(true);
        sound.SetActive(false);
    }

}
