using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelvin
{
    public static class KelvinTemperature
    {
        static double maxKelvin = 6500;
        static double minKelvin = 1000;

        private static double KelvinClamp(double kelvin)
        {
            if (kelvin < minKelvin)
                return minKelvin;

            if (kelvin > maxKelvin)
                return maxKelvin;

            return kelvin;
        }

        internal static RGB KelvinToRGB(double kelvin)
        {
            RGB rgb = new RGB();
            double red, green, blue;

            var temperatureKelvin = KelvinClamp(kelvin);
            var temp = temperatureKelvin / 100;

            if (temp < 66 )
            {
                red = 255;
                green = temp;
                green = 99.4708025861 * Math.Log(green) - 161.1195681661;


                if (temp < 19)
                {
                    blue = 0;
                }
                else
                {
                    blue = temp - 10;
                    blue = 138.5177312231 * Math.Log(blue) - 305.0447927307;
                }
            }
            else
            {
                red = temp - 60;
                red = 329.698727446 * Math.Pow(red, -0.1332047592);

                green = temp - 60;
                green = 288.1221695283 * Math.Pow(green, -0.0755148492);

                blue = 255;
            }

            rgb.Red = red;
            rgb.Green = green;
            rgb.Blue = blue;



            return rgb;
        }
    }
}
