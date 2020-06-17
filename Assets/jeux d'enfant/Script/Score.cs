using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour {
    private int S = 0;
    public Text score;

    public AudioSource winSound;
    public AudioSource loseSound;
	
    public GameObject V;
    public GameObject O;
    public GameObject I;
    public GameObject T;
    public GameObject U;
    public GameObject R;
    public GameObject E;

    public GameObject v;
    public GameObject o;
    public GameObject i;
    public GameObject t;
    public GameObject u;
    public GameObject r;
    public GameObject e;
    public GameObject erreur;

    private int vie;

    void start(){
        winSound = GetComponent<AudioSource>();
        loseSound = GetComponent<AudioSource>();

        vie = 3;
    }

	void OnCollisionEnter(Collision obj)
	{

		if (obj.gameObject.tag == "V") { 
            
			Destroy (obj.gameObject);
            S += 1;
            score.text = "score : " + S.ToString();
            winSound.Play();
            V.SetActive(true);
            v.SetActive(false);

           

        }

        if (obj.gameObject.tag == "O") { 
            
			Destroy (obj.gameObject);
            S += 1;
            score.text = "score : " + S.ToString();

            O.SetActive(true);
            o.SetActive(false);
            winSound.Play();
        }

        if (obj.gameObject.tag == "I") { 
            
			Destroy (obj.gameObject);
            S += 1;
            score.text = "score : " + S.ToString();

            I.SetActive(true);
            i.SetActive(false);
            winSound.Play();
        }

        if (obj.gameObject.tag == "T") { 
            
			Destroy (obj.gameObject);
            S += 1;
            score.text = "score : " + S.ToString();

            T.SetActive(true);
            t.SetActive(false);
            winSound.Play();
        }
        if (obj.gameObject.tag == "U") { 
            
			Destroy (obj.gameObject);
            S += 1;
            score.text = "score : " + S.ToString();

            U.SetActive(true);
            u.SetActive(false);
            winSound.Play();
        }
        if (obj.gameObject.tag == "R") { 
            
			Destroy (obj.gameObject);
            S += 1;
            score.text = "score : " + S.ToString();

            R.SetActive(true);
            r.SetActive(false);
            winSound.Play();
        }

        if (obj.gameObject.tag == "E")
        {

            Destroy(obj.gameObject);
            S += 1;
            score.text = "score : " + S.ToString();

            E.SetActive(true);
            e.SetActive(false);
            winSound.Play();
        }

        if (obj.gameObject.tag == "Manus") { 
			Destroy (obj.gameObject);
            if (S != 0) {
                S -= 1;
                vie -= 1;
                loseSound.Play();
                erreur.SetActive(true);

                if (vie == 0)
                {
                    print("Lost");
                }
            }else{
                S = 0;
            }
            score.text = "score : " + S.ToString();

            

        }
    }
}
