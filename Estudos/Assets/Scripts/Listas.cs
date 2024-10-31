using System;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
    [System.Serializable]
    public class Inimigo
    {
        public string nome;
        public int velocidade;
        public int dano;

        public Inimigo(string nome, int velocidade, int dano) 
        {
            this.nome = nome;
            this.velocidade = velocidade;
            this.dano = dano;
        }
    }

    public List<Inimigo> inimigos = new List<Inimigo>();

	private void Start()
	{
        inimigos.Add(new Inimigo("x", 5, 10));
		inimigos.Add(new Inimigo("y", 3, 16));
	}
}
