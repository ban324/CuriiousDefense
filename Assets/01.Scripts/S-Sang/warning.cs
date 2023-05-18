using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning : MonoBehaviour
{
    public GameObject snipeshreken;
    SpriteRenderer sp;
    float xpos=0, ypos=0;
    // Start is called before the first frame update
    void Awake()
    {
        sp = GetComponentInChildren<SpriteRenderer>();
        StartCoroutine(blinking());
    }
    IEnumerator blinking()
    {
        float xaxis = Random.Range(-10f, 10f);
        float yaxis = Random.Range(-10f, 10f);
        int way = Random.Range(0, 5);
        switch (way)
        {
            case 1:
                ypos += 15f;
                xpos += xaxis;
                break;
            case 2:
                xpos += 15f;
                ypos += yaxis;
                break;
            case 3:
                ypos -= 15f;
                xpos += xaxis;
                break;
            case 4:
                xpos -= 15f;
                ypos += yaxis;
                break;
        }
        transform.rotation = Quaternion.Euler(0, Mathf.Atan2(xpos , ypos)*Mathf.Rad2Deg, 0);

        for (int i=0; i<3;i++) {
            sp.color = new Color(1, 1, 1, 0.5f);
            yield return new WaitForSeconds(0.2f);
            sp.color = new Color(1, 1, 1, 1f);
            yield return new WaitForSeconds(0.2f);
        }
        GameObject t = Instantiate(snipeshreken);
        t.transform.position = new Vector3(xpos, 0.5f, ypos);
        Destroy(gameObject);
    }

}
