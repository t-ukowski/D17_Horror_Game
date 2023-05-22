using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMeshColliderToChildren : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AddMeshColliderToSpecificChildren(this.gameObject);
    }

    void AddMeshColliderToSpecificChildren(GameObject obj) 
    {
        foreach (Transform child in obj.transform) 
        {
            // Check if the name of the object starts with "Wall" or "Stair"
            if (child.name.StartsWith("Wall") || child.name.StartsWith("Stair")) 
            {
                // If the object has a MeshFilter and doesn't already have a MeshCollider
                if (child.GetComponent<MeshFilter>() != null && child.GetComponent<MeshCollider>() == null) 
                {
                    // Add a MeshCollider to the object
                    child.gameObject.AddComponent<MeshCollider>();
                }
            }

            // If the object has children, apply the function recursively
            if (child.childCount > 0) 
            {
                AddMeshColliderToSpecificChildren(child.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
