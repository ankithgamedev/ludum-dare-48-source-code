using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowFps : MonoBehaviour
{

    public float timer, refresh, avgFrameRate;
    public string display = "{0} FPS";
    public TextMeshProUGUI m_Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timelaps = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelaps;

        if (timer <= 0) avgFrameRate = (int)(1f / timelaps);
        m_Text.text = string.Format(display, avgFrameRate.ToString());
    }
}
