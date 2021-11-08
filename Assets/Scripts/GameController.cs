using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] List<GameObject> planets;
    public List<GameObject> Planets { get => planets; }
    GameObject currentPlanet;
    int count = 0;

    [SerializeField] Camera cam;
    [SerializeField] float speed = 3f;

    void Start()
    {
        currentPlanet = Planets[count];
    }

    void Update()
    {
        if(count < 0) count = 0;
        if(count > Planets.Count - 1) count = Planets.Count - 1;

        if(Planets[count] != currentPlanet)
        {
            currentPlanet = Planets[count];
        }

        Vector3 targetPosition = new Vector3(currentPlanet.transform.position.x, currentPlanet.transform.position.y, cam.transform.position.z);

        cam.transform.position = Vector3.MoveTowards(cam.transform.position, targetPosition, Time.deltaTime * speed);
    }

    public void NextPlanet()
    {
        count++;
    }

    public void PrevPlanet()
    {
        count--;
    }
}
