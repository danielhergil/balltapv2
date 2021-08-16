using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControlelr : MonoBehaviour
{

    public GameObject[] platforms;
    public int platformActive;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // max and min range goes from [-8, 8]
    private IEnumerator SetPlatformsCoroutine()
    {
        yield return new WaitForSeconds(0.2f);
        platforms[platformActive].SetActive(false);
        float oldPosition = platforms[platformActive].transform.position.y;
        platformActive = Random.Range(0, 10);
        Vector3 newPos = platforms[platformActive].transform.position;
        newPos.y = Random.Range(-8.0f, 8.0f);
        platforms[platformActive].transform.position = newPos;
        platforms[platformActive].SetActive(true);
    }
    public void SetPlatform()
    {
        StartCoroutine(SetPlatformsCoroutine());
    }
}
