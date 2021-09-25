using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareasemana9
{
    class Bank
    {
        //Metodo de propiedad
        private int _BankId;
        private string _branchname;
        private string _direction;
        private string _Clientnumber;

        //Metodo de propiedad autoimplementada 
        public string _Phonenumber{ get; set; }

        //Metodo constructor
        public Bank() //Metodo vacio 
        { }

        //Metodo de sobrecarga de constructor 
        public Bank(int BankId, string branchname, string direction, string Clientnumber, string Phonenumber)
        {
            _BankId = BankId;
            _branchname = branchname;
            _direction = direction;
            _Clientnumber = Clientnumber;
            _Phonenumber = Phonenumber;
        }

        //Id del banco
        public int getBankId()
        {
            return _BankId;
        }

        public void setBankId(int BankId)
        {
            _BankId = BankId;
        }

        //nombre de la sucursal
        public string getbranchname()
        {
            return _branchname;
        }

        public void setbranchname(string branchname)
        {
            _branchname = branchname;
        }

        //direccion
        public string getdirection()
        {
            return _direction;
        }

        public void setdirection(string direction)
        {
            _direction = direction;
        }

        //numero del cliente
        public string getClientnumber()
        {
            return _Clientnumber;
        }

        public void setClientnumber(string Clientnumber)
        {
            _Clientnumber = Clientnumber;
        }

        //Metodo para mostrar información del Banco
        public string getBankInfo()
        {
            return "ID:   " + _BankId + "Nombre del la sucursal:  " + _branchname + "Direccion:  " + _direction + "Numero del cliente:  " + _Clientnumber + "Numero de telefono:  " + _Phonenumber;

        }

    }
}

    

