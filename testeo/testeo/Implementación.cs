using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeo
{
    class Implementación
    {
        //private string cali;
        public string x;
        /*
        public string Calif
        {
            get { return Calif; }
            set { cali = value; }
        }
        */
        public string lect(double prueba)
        {
            if (prueba <= -1)
            {
               
                return x = "Error!";
            }
            else
            {
                if (prueba <= 49.99)
                {
                   
                    return x = "Fail";
                }
                else
                {
                    if (prueba <= 62.99)
                    {
                        
                        return x = "Pass (C)";
                    }
                    else
                    {
                        if (prueba <= 72.99)
                        {
                            
                            return x = "Credit(B)";
                        }
                        else
                        {
                            if (prueba <= 82.99)
                            {
                                
                                return x = "Distinction(A)";
                            }
                            else
                            {
                                if (prueba <= 100.00)
                                {
                                   
                                    return x = "High Distinctiion(A+)";
                                }
                                else
                                {
                                   
                                    return x = "Error!";
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}

