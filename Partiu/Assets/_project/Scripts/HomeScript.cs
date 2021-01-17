using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{

    [SerializeField] private GameObject trilhas;
    [SerializeField] private GameObject trampos;
    [SerializeField] private GameObject comunidades;
    [SerializeField] private GameObject chatTrampo;
    
    void Start()
    {
        trilhas.SetActive(true);
    }


    public void Trilhas() {
        trilhas.SetActive(true);
        trampos.SetActive(false);
        comunidades.SetActive(false);
        chatTrampo.SetActive(false);
    }

    public void Trampos() {
        trilhas.SetActive(false);
        trampos.SetActive(true);
        comunidades.SetActive(false);
        chatTrampo.SetActive(false);
    }

    public void Comunidades() {
        trilhas.SetActive(false);
        trampos.SetActive(false);
        comunidades.SetActive(true);
        chatTrampo.SetActive(false);
    }

    public void ChatTrampo() {
        trilhas.SetActive(false);
        trampos.SetActive(false);
        comunidades.SetActive(false);
        chatTrampo.SetActive(true);
    }


}
