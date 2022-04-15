using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int points;
    public AudioClip sound;
    // public SoundSource mySource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {        
            GameManager.Instance.score += points;
            //SoundSource source = Instantiate(mySource);
            //source.transform.position = gameObject.transform.position;
            //source.playSound(sound);
            Destroy(gameObject);
        }
    }
}
