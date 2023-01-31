using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    float sphereMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Traveler")
        {
            StartCoroutine(colorchange(col.gameObject));
        }
      
      if (col.gameObject.name == "PizzaSteve")
         {
             Destroy(col.gameObject);
          }
    }
    private IEnumerator colorchange(GameObject go)
    {
        var sphereMaterial = go.GetComponent<Renderer>().material;
        sphereMaterial.color = Color.red;
        yield return new WaitForSeconds(.5f);
        sphereMaterial.color = Color.blue;
        yield return new WaitForSeconds(.5f);
        sphereMaterial.color = Color.green;
        yield return new WaitForSeconds(.5f);
        sphereMaterial.color = Color.magenta;
        yield return new WaitForSeconds(.5f);
        sphereMaterial.color = Color.grey;
        yield return new WaitForSeconds(.5f);
        sphereMaterial.color = Color.yellow;
        yield return new WaitForSeconds(.5f);
        sphereMaterial.color = Color.black;
        yield return new WaitForSeconds(.5f);
        sphereMaterial.color = Color.cyan;
        yield return new WaitForSeconds(.5f);
        sphereMaterial.color = Color.clear;

    }
}
