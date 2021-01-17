using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrilhasScripts : MonoBehaviour
{

    [SerializeField] private GameObject minhaTrilha;
    [SerializeField] private GameObject trilhaTrampos;
    [SerializeField] private GameObject trilhaPegada;
    [SerializeField] private GameObject trilhaCabeca;

    public void MinhaTrilha() {
        minhaTrilha.SetActive(true);
        trilhaTrampos.SetActive(false);
        trilhaPegada.SetActive(false);
        trilhaCabeca.SetActive(false);
    }

    public void TrilhaTrampos() {
        minhaTrilha.SetActive(false);
        trilhaTrampos.SetActive(true);
        trilhaPegada.SetActive(false);
        trilhaCabeca.SetActive(false);
    }

    public void TrilhaPegada() {
        minhaTrilha.SetActive(false);
        trilhaTrampos.SetActive(false);
        trilhaPegada.SetActive(true);
        trilhaCabeca.SetActive(false);
    }

    public void TrilhaCabeca() {
        minhaTrilha.SetActive(false);
        trilhaTrampos.SetActive(false);
        trilhaPegada.SetActive(false);
        trilhaCabeca.SetActive(true);
    }
}
