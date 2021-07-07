using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Modelo
{
    
    public partial class Form1 : Form
    {
        LinkedList<Pessoa> deque = new LinkedList<Pessoa>();
        LinkedList<String> lista = new LinkedList<String>();

        public Form1()
        {
            InitializeComponent();
            carregar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {

        }

        void salvar()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("lista.txt", FileMode.Create)))
            {
                writer.Write(lista.Count());
                foreach (String p in lista)
                {
                    writer.Write(lista.First());
                }
            }

            
        }

        void carregar()
        {
            if (File.Exists("deque.txt"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open("deque.txt", FileMode.Open)))
                {
                    int qtd = reader.ReadInt32();
                    for (int i = 0; i < qtd; i++)
                    {
                        Pessoa p = new Pessoa();
                        p.Nome = reader.ReadString();
                        p.Rg = reader.ReadInt32();
                        p.Idade = reader.ReadInt32();
                        deque.AddLast(p);
                    }// fim for
                }

            }// Fila normal


            mostra();
        }

        void mostra()
        {
            LinkedList<String> listatemp = new LinkedList<String>();

            listPessoas.Items.Clear();
            
            while(lista.Count != 0)
            {
                listPessoas.Items.Add(lista.First.Value);
                listatemp.AddFirst(lista.First.Value);
                lista.RemoveFirst();
            }
            while (listatemp.Count != 0)
            {
               
                lista.AddFirst(listatemp.First.Value);
                listatemp.RemoveFirst();
            }




        }
        //---------------
        void limpa()
        {
            txtNome.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lista.AddFirst(txtNome.Text);
            mostra();
            limpa();

        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(deque.Count > 0)
            {
                Pessoa p = new Pessoa();
                p = deque.First();
                deque.RemoveFirst();
                //lblProx.Text = p.Nome;
                mostra();
            }
            


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            salvar();
        }



        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            
            lista.AddLast(txtNome.Text);
            mostra();
            limpa();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lista.Count != 0)
            {
                MessageBox.Show(lista.First());
            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if(lista.Count !=0 )
            {
                MessageBox.Show(lista.Last());
            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }
            
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            
            if (lista.Count != 0)
            {
                lista.RemoveLast();
                mostra();
            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }
        }

        private void btnRemoveLast2_Click(object sender, EventArgs e)
        {
            lista.RemoveLast();
            mostra();
        }

        private void btnAddAfter_Click(object sender, EventArgs e)
        {
            

            if (lista.Count != 0)
            {
                LinkedListNode<string> no;
                no = lista.FindLast(txtPosicao.Text);

                lista.AddAfter(no, txtNome.Text);

                mostra();
            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRemoveLast_Click_1(object sender, EventArgs e)
        {
            

            if (lista.Count != 0)
            {
                lista.RemoveLast();
                mostra();
            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }
        }

        private void btnAddBefore_Click(object sender, EventArgs e)
        {
            

            if (lista.Count != 0)
            {
                LinkedListNode<string> no;
                no = lista.FindLast(txtPosicao.Text);

                lista.AddBefore(no, txtNome.Text);

                mostra();
            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }
        }
    }
}
