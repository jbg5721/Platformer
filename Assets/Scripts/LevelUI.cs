using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelUI : MonoBehaviour
{
    public TextMeshProUGUI score;

    void Update()
    {
        score.text = GameManager.Instance.score.ToString();
    }

}
