using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareasemana9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creamos la instancia del banco
            Bank bank = new Bank();
            //Creamos un objeto

            //Asignar valores a las propiedades
            bank.setBankId(1);
            bank.setbranchname("");
            bank.setdirection("");
            bank.setClientnumber("");


            //Asignar valores a propiedades autoimplementadas 

            bank._Phonenumber = ("");
            //Mostrar datos del banco


        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            //Instancia de la clase utilizando constructores 

            //Utilizando constructor vacio 
            Bank bank = new Bank();
            bank.setBankId(Convert.ToInt32(txtID.Text));
            bank.setbranchname(txtBranchname.Text);
            bank.setdirection(txtDirection.Text);
            bank.setClientnumber ( txtClientnumber.Text);
            bank._Phonenumber = txtPhonenumber.Text;


            //Constructor que inicializa todas las propiedades
            Bank bank1 = new Bank(Convert.ToInt32(txtID.Text),
                txtBranchname.Text, txtDirection.Text, txtClientnumber.Text, txtPhonenumber.Text);


            //agregar los datos a listbox
            lstbankInfo.Items.Add("Mediante constructor vacío: " + bank.getBankInfo());
            lstbankInfo.Items.Add("Mediante constructor inicializando las propiedades: " + bank.getBankInfo());
        }
    }

}








    

