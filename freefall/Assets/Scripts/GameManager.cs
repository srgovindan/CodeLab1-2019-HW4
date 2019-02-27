using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject Player;
    
    private Vector3 startPos;
    public Vector3 StartPos
    {
        get 
        {
            Debug.Log(startPos);
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
            Debug.Log(endPos);
            return endPos;
        }
        set
        {
            endPos = value;
        }
    }

    private float range;
    private float height;

    
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
        
        //
        Player = GameObject.Find("Player");
        StartPos = Player.transform.position;
    }

 

    public void HitWater(Transform end)
    {
        EndPos = end.position;
        range = Mathf.Sqrt((endPos.x-startPos.x)*(endPos.x-startPos.x))+((endPos.z-startPos.z)*(endPos.z-startPos.z));
        //height
        Debug.Log("Range: "+range);
        // reset game?
    }
}
