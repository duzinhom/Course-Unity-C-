using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    int qtdVida, qtdMoeda, energia;
    string nome;

    int valor1 = 12, valor2 =10, result;

    int engine = 20;

    string[] viloes = { "vilao1", "vilao2", "vilao3", "vilao4", "vilao5" };

    List<int> lista = new List<int>();

    zumbi zumbi1;
    zumbi_filho zumbi2;
	// Use this for initialization
	void Start () {
        zumbi1 = new zumbi();
        zumbi2 = new zumbi_filho();

		result = valor1 + valor2;
        print(result);

        if (engine > 10)
        {
            print("Unity");
        }

        for (int i = 0 ; i <= 10 ; i++)
        {
            print(i);
            lista.Add(20 + i);
        }

       for (int x = 0; x < viloes.Length; x++)
        {
            print(viloes[x]);
        }

       foreach (int item in lista)
        {
            print(item);
        }

        print(zumbi1.vida);

        zumbi1.andar();
        zumbi2.andar();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    class zumbi: MonoBehaviour
    {
        public int vida=100;

        public virtual void andar()
        {
            print("zumbi pai");
        }
    }

    class zumbi_filho : zumbi
    {
        public override void andar()
        {
            print("zumbi filho");
        }
    }

}
