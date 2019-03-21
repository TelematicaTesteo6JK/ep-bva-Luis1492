using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Implementación manda = new Implementación();

        private void cmdTest_Click(object sender, EventArgs e)
        {
            string[] vec = new string[5];
            TextWriter texto;
            texto = new StreamWriter("archivo.txt");
            bool bandera = false;
            string p="";
            string v ="";
            double m = Convert.ToDouble(txtnumero.Text);
            string r = manda.lect(m);
            txtresult.Text = r;
            vec[0] = ("Test Report Result " + "\n" + "Test Data |" + "\t" + "Expected Result |" + "\t" + "Actual Result |" + "\t" + "Pass/Fail" );
            for (int l=1; l<=vec.Length; l++)
            {
                if (r == "Fail" && m <= 49.99)
                {
                    v = "F";
                    p = "Pass";
                    vec[l] = Convert.ToString(m) + "\t " + v + "\t" + r + " \t" + p;
                    break;
                }
                else
                {
                    if (r == "Pass (C)" && m <= 62.99)
                    {
                        v = "C";
                        p = "Pass";
                        vec[l] = Convert.ToString(m) + "\t " + v + "\t" + r + " \t" + p;
                        break;
                    }
                    else
                    {
                        if (r == "Credit(B)" && m <= 72.99)
                        {
                            v = "B";
                            p = "Pass";
                            vec[l] = Convert.ToString(m) + "\t " + v + "\t" + r + " \t" + p;
                            break;
                        }
                        else
                        {
                            if (r == "Distinction(A)" && m <= 82.99)
                            {
                                v = "A";
                                p = "Pass";
                                vec[l] = Convert.ToString(m) + "\t " + v + "\t" + r + " \t" + p;
                                break;
                            }
                            else
                            {
                                if (r == "High Distinctiion(A+)" && m <= 100.00)
                                {
                                    v = "A+";
                                    p = "Pass";
                                    vec[l] = Convert.ToString(m) + "\t " + v + "\t" + r + " \t" + p;
                                    break;
                                }
                                else
                                {
                                    if (r == "Error!")
                                    {
                                        v = "F";
                                        p = "Fail";
                                        vec[l] = Convert.ToString(m) + "\t " + v + "\t" + r + " \t" + p;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int l = 0; l < vec.Length && bandera != true; l++ )
            {
                if (vec[l] == null)
                {
                    texto.WriteLine(vec[l]);
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                    
                
            }
            texto.Close();
                
        }
    }
}
