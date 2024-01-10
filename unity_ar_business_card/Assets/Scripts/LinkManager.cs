using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    public void OpenLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/clintonhendrickson/");
    }

    public void OpenEmail()
    {
        Application.OpenURL("lessismoreclint@gmail.com");
    }
}