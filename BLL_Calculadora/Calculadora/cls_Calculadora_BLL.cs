using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Calculadora.Calculadora;

namespace BLL_Calculadora.Calculadora
{
    public class cls_Calculadora_BLL
    {
        public void calculos(ref cls_Calculadora_DAL obj_DAL)
        {
            switch (obj_DAL.cOperacion) 
            {
                case '+':
                    obj_DAL.fResultado = obj_DAL.fNum1 + obj_DAL.fNum2;
                    break;
                case '-':
                    obj_DAL.fResultado = obj_DAL.fNum1 - obj_DAL.fNum2;
                    break;
                case '*':
                    obj_DAL.fResultado = obj_DAL.fNum1 * obj_DAL.fNum2;
                    break;
                case '/':
                    obj_DAL.fResultado = obj_DAL.fNum1 / obj_DAL.fNum2;
                    break;

            }
        }
        public void sumar(ref cls_Calculadora_DAL obj_DAL)
        {
            obj_DAL.fResultado = obj_DAL.fNum1 + obj_DAL.fNum2;
        }

        public void restar(ref cls_Calculadora_DAL obj_DAL)
        {
            obj_DAL.fResultado = obj_DAL.fNum1 - obj_DAL.fNum2;
        }

        public void multiplicar(ref cls_Calculadora_DAL obj_DAL)
        {
            obj_DAL.fResultado = obj_DAL.fNum1 * obj_DAL.fNum2;
        }

        public void dividir(ref cls_Calculadora_DAL obj_DAL)
        {
            obj_DAL.fResultado = obj_DAL.fNum1 / obj_DAL.fNum2;
        }

        public void NumMenor(ref cls_Calculadora_DAL obj_DAL)
        {
            if (obj_DAL.fNum1 < obj_DAL.fNum2)
            {
                obj_DAL.fValidaMenor = obj_DAL.fNum1;
            }
            else
            {
               obj_DAL.fValidaMenor = obj_DAL.fNum2;
            }
        }

        public void NumMayor(ref cls_Calculadora_DAL obj_DAL)
        {
            if (obj_DAL.fNum1 > obj_DAL.fNum2)
            {
                obj_DAL.fValidaMayor = obj_DAL.fNum1;
            }
            else
            {
                obj_DAL.fValidaMayor = obj_DAL.fNum2;
            }
        }

        public void ParImparNum1(ref cls_Calculadora_DAL obj_DAL)
        {
            if (obj_DAL.fNum1 % 2 != 0)
            {
                obj_DAL.sValidaParImpar = "IMPAR";
            }
            else
            {
                obj_DAL.sValidaParImpar = "PAR";
            }    
        }

        public void ParImparNum2(ref cls_Calculadora_DAL obj_DAL)
        {
            if (obj_DAL.fNum2 % 2 != 0)
            {
                obj_DAL.sValidaParImpar = "IMPAR";
            }
            else
            {
                obj_DAL.sValidaParImpar = "PAR";
            }
        }







    }
}
