using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Url : MonoBehaviour
{
    public void OpenYTChannel()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC8tK3qx72TM2F2CAW_a3PgA");
    }

    public void OpenLDJam()
    {
        Application.OpenURL("https://ldjam.com");
    }
}
