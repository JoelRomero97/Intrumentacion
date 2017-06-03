using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicWinUSB.Class
{
    public class lectura_de_datos
    {
        public double numero_1 { get; set; }
        public double numero_2 { get; set; }
        public bool led_verde { get; set; }
        public bool led_rojo { get; set; }

    public lectura_de_datos(double numero1, double numero2)
        {
            this.numero_1 = numero1;
            this.numero_2 = numero2;
        }

        public lectura_de_datos()
        {

        }

        /*

        public double get_numero_1()
        {
            return this.numero_1;
        }

        public double get_numero_2()
        {
            return this.numero_2;
        }

        public void set_numero_1(double n)
        {
            this.numero_1 = n;
        }

        public void set_numero_2(double n)
        {
            this.numero_2 = n;
        }

        public bool get_led_verde()
        {
            return this.led_verde;
        }

        public bool get_led_rojo()
        {
            return this.led_rojo;
        }

        public void set_led_verde(bool b)
        {
            this.led_verde = b;
        }

        public void set_led_rojo(bool b)
        {
            this.led_rojo = b;
        }
        */

    }
}
