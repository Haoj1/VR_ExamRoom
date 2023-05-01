using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScoreOnSelect : MonoBehaviour
{
    public GameObject[] OtherSelction;
    public bool selected;
    private MeshRenderer meshRenderer;
    private Material material;
    private ExamScore examScore;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.material;
        Color color = material.color;
        color.a = 0.0f;
        material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (selected == true)
        {
            Color color = material.color;
            color.a = 0.5f;
            material.color = color;
        }
        else
        {
            Color color = material.color;
            color.a = 0.0f;
            material.color = color;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Pencil")
        {
            selected = true;
            foreach (GameObject obj in OtherSelction)
            {
                GetScoreOnSelect otherScript = obj.GetComponent<GetScoreOnSelect>();
                otherScript.selected = false;
            }
        }
    }
}
