using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class objectiveFearZone : MonoBehaviour
{
    public GameObjectHandler objectHandler;
    public ControllerMovement controller;
    public List<GameObject> objectiveFearList = new List<GameObject>();
    public GameObject[] objectiveFearObjects;
    public GameObject prefab;
    public GameObject Controller;
    public Transform spawnPoint;
    public StartConfig startConfig;

    public Text countDown;
    public GameObject countdown;
    private float time = 5f;
    private bool entered = false;

    void Start()
    {
        countdown.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (entered)
        {
            countdown.SetActive(true);
            if (time > 1)
            {
                time -= Time.deltaTime;
                countDown.text = time.ToString("0");
            }
            else
            {
                countdown.SetActive(false);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Delay());
        //entered = true;
        //StartCoroutine(WaitObjectiveFear());
        //Debug.Log("entered objective fear zone");
    }

    private void OnTriggerExit(Collider other)
    {
        entered = false;
        countdown.SetActive(false);
        time = 5f;
        var fearDistance = GameObject.FindGameObjectWithTag("fearDistance");
        fearDistance.SetActive(false);
        this.gameObject.SetActive(false);
        controller.calculateDistance();
        objectHandler.showCurvedArrow();
        objectHandler.displayStartPositionZone();
        startConfig.configRoom();
        //Debug.Log("exit objectiveFearZone");
    }

    IEnumerator Delay(){
        yield return new WaitForSeconds(3);
        entered = true;
        StartCoroutine(WaitObjectiveFear());

    }

    IEnumerator WaitObjectiveFear()
    {
        yield return new WaitForSeconds(5);
        if(entered){
            var Instance = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
            Instance.transform.parent = Controller.transform;
        }


    }
    
}
