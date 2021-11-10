using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] List<GameObject> planets;
    public List<GameObject> Planets { get => planets; }
    GameObject currentPlanet;
    int count = 0;
    string[] titlePlanet = new string[5];
    string[] textPlanet = new string[5];

    [SerializeField] Camera cam;
    [SerializeField] float speed = 3f;

    [SerializeField] Text title;
    [SerializeField] Text text;

    void Start()
    {
        currentPlanet = Planets[count];

        titlePlanet[0] = "Atracción";
        textPlanet[0] = "Generar acciones que permitan vincular al mejor talento en base a la cultura UDLA.";

        titlePlanet[1] = "Capacitación";
        textPlanet[1] = "Brindar herramientas orientadas al desarrollo y fortalecimiento de conocimientos, habilidades y competencias.";

        titlePlanet[2] = "Gestión de Talento";
        textPlanet[2] = "Evaluar el desempeño y potencial de colaboradores UDLA para trabajar en estrategias de desarrollo.";

        titlePlanet[3] = "Gestión de Estructura y Compensación";
        textPlanet[3] = "Gestionar la estructura organizacional de la Universidad, que apalanque de manera efectiva los distintos procesos; y definir las pautas para el manejo del esquema remunerativo entre la Universidad y sus colaboradores.";

        titlePlanet[4] = "Cultura y gestión de cambio";
        textPlanet[4] = "Ejecutar y desarrollar acciones enfocadas a fortalecer la cultura y clima institucional facilitando los proccesos de gestión de cambio.";
    }

    void Update()
    {
        if(count < 0)
        {
            count = 0;
        }
        
        if(count > Planets.Count - 1)
        {
            count = Planets.Count - 1;
        }

        if(Planets[count] != currentPlanet)
        {
            currentPlanet = Planets[count];
        }

        Vector3 targetPosition = new Vector3(currentPlanet.transform.position.x + 3.5f, currentPlanet.transform.position.y, currentPlanet.transform.position.z - 10f);

        cam.transform.position = Vector3.MoveTowards(cam.transform.position, targetPosition, Time.deltaTime * speed);

        title.text = titlePlanet[count];
        text.text = textPlanet[count];
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
