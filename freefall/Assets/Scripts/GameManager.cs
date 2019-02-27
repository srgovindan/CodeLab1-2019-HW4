using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private GameObject Player;

    public Text ReportText;
    
    private Vector3 startPos;
    public Vector3 StartPos
    {
        get 
        {
            return startPos;  
        }
        set
        {
            startPos = value;
        }
    }
    
    private Vector3 endPos;
    public Vector3 EndPos
    {
        get
        {
            return endPos;
        }
        set
        {
            endPos = value;
        }
    }

    private float range;
    public float Range
    {
        get
        {
            return range;
        }
        set
        {
            range = value;
            Debug.Log("Range: "+range);
        }
    }

    private float height;
    public float Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
            Debug.Log("Height: "+height);
        }
    }


    void Start()
    {
        // SINGLETON
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
        // Find Player object
        Player = GameObject.Find("Player");
        StartPos = Player.transform.position;
    }

 

    public void HitWater(Transform end)
    {
        EndPos = end.position;
        Range = Mathf.Sqrt((EndPos.x-StartPos.x)*(EndPos.x-StartPos.x)+(EndPos.z-StartPos.z)*(EndPos.z-StartPos.z));
        Height = Mathf.Abs(EndPos.y-StartPos.y);
        ReportText.text = "You fell " + Height + "m and leapt across " + Range + "m.";
       
        // reset game?
    }
}
