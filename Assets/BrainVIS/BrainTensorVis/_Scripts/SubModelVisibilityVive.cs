using UnityEngine;
using System.Collections;

public class SubModelVisibilityVive : MonoBehaviour
{
    public GameObject[] subModels;

    private int currIdx = 0;

    public void ChangeVisibility()
    {
        if (currIdx >= this.subModels.Length)
        {
            foreach (GameObject obj in this.subModels)
            {
                obj.SetActive(true);
            }
            currIdx = 0;
        }
        else
        {
            for (int i = 0; i < this.subModels.Length; i++)
            {
                this.subModels[i].SetActive(i == currIdx);
            }
            currIdx += 1;
        }
    }

}
