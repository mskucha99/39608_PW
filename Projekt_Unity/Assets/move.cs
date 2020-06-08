using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class move : MonoBehaviour
{
    NavMeshAgent myNav;
    public GameObject end;
    void Start()
    {
        myNav = GetComponent<NavMeshAgent>();
        myNav.SetDestination(end.transform.position);
    }
}
