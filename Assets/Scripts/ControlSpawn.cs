using UnityEngine;

public class ControlSpawn : MonoBehaviour
{
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;

    float waitShow1 = 0;
    float waitShow2 = 0;
    float waitShow3 = 0;
    float waitShow4 = 0;

    float timer1;
    float timer2;
    float timer3;
    float timer4;

    public GameObject[] ob;

    // Use this for initialization
    private void Start()
    {
        waitShow1 = Random.Range(0f, 3f);
        waitShow2 = Random.Range(0f, 3f);
        waitShow3 = Random.Range(0f, 3f);
        waitShow4 = Random.Range(0f, 3f);
    }

    // Update is called once per frame
    private void Update()
    {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;
        timer4 += Time.deltaTime;

        if (timer1 > waitShow1)
        {
            GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spawn1.transform.position, spawn1.transform.rotation);
            waitShow1 = Random.Range(4f, 7f);
            timer1 = 0;
        }

        if (timer2 > waitShow2)
        {
            GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spawn2.transform.position, spawn2.transform.rotation);
            waitShow1 = Random.Range(4f, 7f);
            timer2 = 0;
        }

        if (timer3 > waitShow3)
        {
            GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spawn3.transform.position, spawn3.transform.rotation);
            waitShow1 = Random.Range(4f, 7f);
            timer3 = 0;
        }

        if (timer4 > waitShow4)
        {
            GameObject.Instantiate(ob[Random.Range(0, (ob.Length))], spawn4.transform.position, spawn4.transform.rotation);
            waitShow4 = Random.Range(4f, 7f);
            timer4 = 0;
        }
    }
}