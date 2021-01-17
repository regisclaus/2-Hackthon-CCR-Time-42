using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EscolhaUsuarioScript : MonoBehaviour
{

    private Usuario usuario = Usuario.JOVEM;

    [SerializeField] private GameObject jovemTela;

    [SerializeField] private GameObject empresarioTela;

    [SerializeField] private DOTweenAnimation imagemJovem;

    [SerializeField] private DOTweenAnimation imagemEmpresario;

    public void AnimaJovem() {
        imagemJovem.gameObject.SetActive(true);
        imagemJovem.DORestart();
        imagemEmpresario.gameObject.SetActive(false);
        usuario = Usuario.JOVEM;
    }

    public void AnimaEmpresario() {
        imagemEmpresario.gameObject.SetActive(true);
        imagemEmpresario.DORestart();
        imagemJovem.gameObject.SetActive(false);
        usuario = Usuario.EMPRESARIO;
    }

    public void Entrar() {
        switch(usuario) {
            case Usuario.JOVEM:
            GetComponent<ScreenScript>().GoToNextScreen(jovemTela);
            break;
            case Usuario.EMPRESARIO:
            GetComponent<ScreenScript>().GoToNextScreen(empresarioTela);
            break;
        }
    }
}

public enum Usuario { JOVEM, EMPRESARIO }
