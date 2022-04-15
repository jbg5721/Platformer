using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAnimation : MonoBehaviour
{
    public int delayInSeconds = 0;

    private void Awake()
    {
        gameObject.GetComponent<Animator>().enabled = false;
    }
    void Start()
    {
        StartCoroutine(playAnimation());
    }

    IEnumerator playAnimation()
    {
        yield return new WaitForSeconds(delayInSeconds);
        gameObject.GetComponent<Animator>().enabled = true;
    }
}
