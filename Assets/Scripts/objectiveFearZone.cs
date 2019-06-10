using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class objectiveFearZone : MonoBehaviour
{
    public GameObjectHandler objectHandler;
    public ControllerMovement controller;
    public List<GameObject> objectiveFearList = new List<GameObject>();
    public GameObject[] objectiveFearObjects;
    public GameObject prefab;
    public GameObject Controller;
    public Transform spawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(WaitObjectiveFear());
        Debug.Log("entered objective fear zone");
    }

    private void OnTriggerExit(Collider other)
    {
        var fearDistance = GameObject.FindGameObjectWithTag("fearDistance");
        fearDistance.SetActive(false);
        this.gameObject.SetActive(false);
        controller.calculateDistance();
        objectHandler.displayStartPositionZone();
        Debug.Log("exit objectiveFearZone");
    }

    IEnumerator WaitObjectiveFear()
    {
        yield return new WaitForSeconds(3);
        var Instance = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        Instance.transform.parent = Controller.transform;

    }
    
}
