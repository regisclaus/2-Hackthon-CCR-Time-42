using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class CursoScript : MonoBehaviour
{

    [SerializeField] private Slider barraProgresso;

    [SerializeField] private ScreenScript[] atividadesScreens;

    [SerializeField] private Button proximoBotao;

    [SerializeField] private Button voltaBotao;


    private int indexAtividade = 0;

    private void Start()
    {
        UpdateBarraProgresso();
    }

    private void UpdateBarraProgresso()
    {
        barraProgresso.value = (float) (indexAtividade+1) / (float) atividadesScreens.Length;
    }

    public void ProximaAtividade() {

        atividadesScreens[indexAtividade].GoToNextScreen(atividadesScreens[indexAtividade + 1].gameObject);
        indexAtividade++;

        if(indexAtividade == atividadesScreens.Length - 1) {
            proximoBotao.gameObject.SetActive(false);
        }
        else {
            proximoBotao.gameObject.SetActive(true);
        }

        voltaBotao.gameObject.SetActive(true);
        UpdateBarraProgresso();
    }

    public void VoltaAtividade() {

        atividadesScreens[indexAtividade].GoToPreviousScreen(atividadesScreens[indexAtividade - 1]);
        indexAtividade--;

        if(indexAtividade == 0) {
            voltaBotao.gameObject.SetActive(false);
        }
        else {
            voltaBotao.gameObject.SetActive(true);
        }

        proximoBotao.gameObject.SetActive(true);

        
        UpdateBarraProgresso();
    }

    public void SairCurso(ScreenScript telaAnterior){


        // foreach (ScreenScript atividade in atividadesScreens)
        // {
        //     atividade.EnterAnimation();
        // }

        for(int i = indexAtividade; i >= 1; i--) {
            VoltaAtividade();
        }

        indexAtividade=0;

        GetComponent<ScreenScript>().GoToPreviousScreen(telaAnterior);
    }


 }
