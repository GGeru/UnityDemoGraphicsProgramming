using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public Texture2D HeightTex;
    public GameObject tree;

    private void Start()
    {
        
        Color32 pixelColor;
        Material material = GetComponent<Material>();
        MeshFilter mf = GetComponent<MeshFilter>();
        Vector3 worldPos;
        Vector3 meshPos;
        
        for (int i = 0; i < mf.mesh.vertices.Length; i++) {
            Debug.Log(mf.mesh.colors32.Length);
            pixelColor = mf.mesh.colors32[i];
            if (pixelColor == new Color(55, 176, 31)) {
                meshPos = mf.mesh.vertices[i];
                worldPos = transform.TransformPoint(meshPos);
                Instantiate(tree, worldPos, Quaternion.identity);
            }
        }

        //for (int u = 0; u < tex.width; u++) {
        //    for (int v = 0; v < tex.height; v++) {
        //        pixelColor = HeightTex.GetPixelBilinear(u, v);
        //        if (pixelColor == new Color(55, 176, 31)) {
        //            HeightTex.GetPixelData<TerrainHeightmapSyncControl>(1);
        //        }
        //    }
        //}


    }
}
