using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ANVC.Scalar;
using SimpleJSON;

public class AccessScalarBookMod : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Request the home page for the book, plus its path relationships
        StartCoroutine(ScalarAPI.LoadNode("virtual-viking-longship-annotated", HandleSuccess, HandleError, 1, false, "annotation"));
    }

    public void HandleSuccess(JSONNode json)
    {
        Debug.Log("Received Scalar data");

        // Get the home page for the book
        ScalarNode unityScene = ScalarAPI.GetNode("virtual-viking-longship-annotated");

        // Get the path children of the book's home page
        Debug.Log(unityScene);
        Debug.Log(unityScene.GetRelatedNodes("annotation", "incoming"));
    }

    public void HandleError(string error)
    {
        Debug.Log(error);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
