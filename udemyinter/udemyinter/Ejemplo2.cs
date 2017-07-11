using System;

namespace udemyinter
{
    class Ejemplo2
    {
        private int _uno, _dos, _tres;

        public void Metodo1(int numerito)
        {
            _uno = numerito;


        }

        public void Metodo2(string argumento1)
        {

            this._dos = 45465;
            Console.WriteLine(argumento1 + (_dos));
        }

    }
}