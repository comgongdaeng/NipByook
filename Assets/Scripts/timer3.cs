using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer3 : MonoBehaviour
{
    
    public Text[] text_time; // 시간을 표시할 text
    public static float time; // 시간.
    public AudioClip Gameover;

    private void Start()
    {
        time = 300; //1분으로 설정
    }

    void Update() 
    {

            time -= Time.deltaTime;
            //text_time[0].text = ((int)time / 3600).ToString();
            text_time[0].text = ((int)time / 60%60).ToString();
            text_time[1].text = ((int)time % 60 ).ToString();

            if(time <=0) 
            {
            SceneController.GoLevel1();
            AudioSource.PlayClipAtPoint(Gameover, Vector3.zero);

            }
    }
}