using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(166, 37, 0);
   
    void Update()
    {transform.position = player.transform.position + offset;}
}
