﻿using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player ;
    public Text score_text;

    // Update is called once per frame
    void Update()
    {
        score_text.text =  player.position.z.ToString("0") ;
    }
}
  