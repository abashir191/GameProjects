// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class ZomGenerator : MonoBehaviour
{
    public GameObject zombie;

    public float min;
    public float max;
    public float curr;

    public float speedIncrease;
    // Start is called before the first frame update
    void Awake()
    {
        curr = min;
        generateZombie();
    }

    public void RandomZombie()
        {
            float randomZom = Random.Range(0.1f, 1.2f);
            Invoke("generateZombie", randomZom);

        }

    public void generateZombie()
    {
        GameObject ZombieIns = Instantiate(zombie, transform.position, transform.rotation);

        ZombieIns.GetComponent<ZombieScript>().zomGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(curr < max)
        {
            curr += speedIncrease;
        }
    }
}
