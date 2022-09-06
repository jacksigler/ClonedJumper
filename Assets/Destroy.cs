using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{

    public Text text;
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    public GameObject myPlat;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*void OnTriggerEnter2D(Collider player) {
        SceneManager.LoadScene(Menu);
    }*/

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name.StartsWith("Platform"))
        {

            if (Random.Range(1, 8) == 1)
            {

                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-5f, 5f), player.transform.position.y + (14 + Random.Range(0.5f, 2f))), Quaternion.identity);


            } else
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-5, 5f), player.transform.position.y + (14 + Random.Range(0.5f, 2f)));

            }

        } 
        else if(collision.gameObject.name.StartsWith("Spring"))
        {

            if (Random.Range(1, 7) == 1)
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-5f, 5f), player.transform.position.y + (14 + Random.Range(0.2f, 2f)));

            }
            else
            {

                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-5f, 5f), player.transform.position.y + (14 + Random.Range(0.5f, 2f))), Quaternion.identity);


            }

        }
    }
}
