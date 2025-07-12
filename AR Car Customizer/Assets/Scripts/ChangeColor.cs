using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;

    public void Red()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[0];
    }
    public void Black()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[1];
    }
    public void Blue()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[2];
    }
    public void Yellow()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[3];
    }
    public void Gray()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[4];
    }
    public void Orange()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[5];
    }
    public void Purple()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[6];
    }
    public void LightBlue()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[7];
    }
    public void Green()
    {
        for (int i = 0; i < mats.Length; i++) mats[i].material.color = colors[8];
    }
}
