using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growcube : MonoBehaviour
{
    public GameObject cube;
    public GameObject sun;
    Vector3 direction;
    int distance;
    int activated;
    int count;
    int limitcount;
    int lifetime;
    public static int totalcycles;
    public bool alive;
    // Start is called before the first frame update
    void Start()
    {
        /*count = 0;
        activated = Random.Range(0,200);
        if(activated > 900)
        {
            direction.x = Random.Range(-1f, 1f);
            direction.z = 0;
            direction.y = 0.1f;
            distance = Random.Range(1000, 5000);
        }*/

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.Escape))
        {
            totalcycles = 100000000;
        }
        if (alive)
        {
            limitcount = 2;
            if (totalcycles <5000)
            {
                totalcycles++;

                if (limitcount > 1)
                {


                    if (activated > 90)
                    {
                        if (count < distance)
                        {
                            GameObject gam = Instantiate(cube, gameObject.transform.position + direction * count, new Quaternion());
                            //gam.transform.position =new Vector3( gam.transform.position.x + (sun.gameObject.transform.position.x - gameObject.transform.position.x) / 30, gam.transform.position.y, gam.transform.position.z);
                            if (count > distance/2)
                            {
                            if(Random.Range(0,100)>80)
                            {
                                gam.GetComponent<growcube>().alive = true;
                            }
                            else
                                gam.GetComponent<growcube>().alive = false;
                        }
                            else
                                gam.GetComponent<growcube>().alive = false;
                        }
                        count++;
                    }
                    else
                    {
                        if (lifetime < 2)
                        {
                            activated = Random.Range(0, 100);
                            if (activated > 90)
                            {
                                lifetime++;
                                direction.x = Random.Range(-1f, 1f);
                                if (direction.x < 0 && direction.x > -0.1f)
                                    direction.x = -0.1f;
                                if(direction.x >0 && direction.x<0.1f)
                                {
                                    direction.x = 0.1f;
                                }
                              // direction.x += (sun.gameObject.transform.position.x - gameObject.transform.position.x)/50;
                                direction.z = 0;
                                direction.y = 1;
                                distance = Random.Range(10,200);
                              
                            }
                            else
                                activated = 0;
                        }
                    }
                    limitcount = 0;
                }
            }
        }
    }
}
