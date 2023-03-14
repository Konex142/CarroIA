using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
using Unity.VisualScripting;

public class Ui_Carros : MonoBehaviour
{
    public Carro meuCarro;
    public TMP_Text nomeT;
    public TMP_Text voltaT;
    public TMP_Text posT;
    public TMP_Text velT;
    public GameObject Telavitoria;
    public TMP_Text[] posF;
    
    void Update()
    {
        nomeT.text = "Nome: "+meuCarro.name;
        voltaT.text = "Volta: "+meuCarro.volta.ToString();
        velT.text = meuCarro.GetComponent<NavMeshAgent>().speed.ToString()+" Km/h";
        posT.text = "Pos: "+meuCarro.pos.ToString();

        if(meuCarro.volta == 2)
        {
            Time.timeScale= 0;
            Telavitoria.SetActive(true);
            GameObject[] carros = GameObject.FindGameObjectsWithTag("Carro");
            for(int i = 0; i < posF.Length; i++ )
            {
                posF[carros[i].GetComponent<Carro>().pos - 1].text = carros[i].name;
            }
        }
    }
}
