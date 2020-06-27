using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Inventario
{
    public class Utilidades
    {
        public void ConsoleBackgroud()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public bool ConverDate(string cadena)
        {
            DateTime fecha;
            try
            {
                fecha = DateTime.Parse(cadena);
                return false;
            }
            catch
            {

            }
            return true;
        }

        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        public string MascaraContraseña()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleKeyInfo key;
            string contraseña = "";
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    contraseña += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (contraseña != "")
                    {
                        Console.Write("\b \b");
                        contraseña = contraseña.Remove(contraseña.Length - 1);
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter);
            Console.ForegroundColor = ConsoleColor.Cyan;
            return contraseña;
        }

        public void LetterNumber(int opcion,int txtLenght,int maxLenght,KeyPressEventArgs e)
        {
            if (txtLenght<=maxLenght || (e.KeyChar == (char)Keys.Back))
            {
                switch (opcion)
                {
                    case 1:
                        if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                        {
                            MessageBox.Show("Solo se permiten letras", "Advertencia",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            e.Handled = true;
                            return;
                        }
                        break;
                    case 2:
                        if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                        {
                            MessageBox.Show("Solo se permiten numeros", "Advertencia",
                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            e.Handled = true;
                            return;
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Maximo de caracteres alcanzado", "Advertencia",
                                             MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
     

        }

        public string LetterNumber(int opcion, int lenghMax,int maxNumero)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string cadena = "";
            do
            {
                cadena = "";
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace)
                    {
                        if (opcion==1 && cadena.Length<lenghMax && char.IsLetter(key.KeyChar) && key.KeyChar != 32)
                        {
                                cadena += key.KeyChar;
                                Console.Write(key.KeyChar);
                        }
                        if (opcion== 2 && cadena.Length < lenghMax)
                        {
                            cadena += key.KeyChar;
                            Console.Write(key.KeyChar);
                        }
                        else
                        {
                            if (char.IsDigit(key.KeyChar) && key.KeyChar != 32 && cadena.Length<lenghMax && int.Parse(key.KeyChar.ToString())<=maxNumero)
                            {
                                cadena += key.KeyChar;
                                Console.Write(key.KeyChar);
                            }
                        }
                    }
                    else
                    {
                        if (cadena != "")
                        {
                            Console.Write("\b \b");
                            cadena = cadena.Remove(cadena.Length - 1);
                        }
                    }
                } while (key.Key != ConsoleKey.Enter);
            } while (cadena.Length == 0);
            Console.ForegroundColor = ConsoleColor.Cyan;
            return cadena;
        }

        public String GetMD5Hash(String input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();
            return hash;
        }

    }
}
