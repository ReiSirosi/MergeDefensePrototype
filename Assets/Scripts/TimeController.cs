using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public void NormalTime()
    {
        Time.timeScale = 1f;
    }

    public void DoubleTime()
    {
        Time.timeScale = 2f;
    }

    public void TripleTime()
    {
        Time.timeScale = 3f;
    }
}
