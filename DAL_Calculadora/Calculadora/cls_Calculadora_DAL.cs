using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Calculadora.Calculadora
{
    public class cls_Calculadora_DAL
    {
        #region VARIABLES PRIVADAS

        private float _fNum1, _fNum2, _fResultado, _fvalidaMayor, _fvalidaMenor;
        private string _svalidaParImpar,_sMsjError;
        private char _cOperacion;
        #endregion

        #region CONSTRUCTORES O VARIABLES PUBLICAS
        public float fNum1 { get => _fNum1; set => _fNum1 = value; }
        public float fNum2 { get => _fNum2; set => _fNum2 = value; }
        public float fResultado { get => _fResultado; set => _fResultado = value; }
        public float fValidaMayor { get => _fvalidaMayor; set => _fvalidaMayor = value; }
        public float fValidaMenor { get => _fvalidaMenor; set => _fvalidaMenor = value; }
       public string sValidaParImpar { get => _svalidaParImpar; set => _svalidaParImpar = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public char cOperacion { get => _cOperacion; set => _cOperacion = value; }

        #endregion
    }
}
