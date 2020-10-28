using System;

namespace KalkulatorBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            float _fWaga = 0f;
            float _fWzrost = 0f;
            float _fBMI = 0f;

            int _iLicznikPowtorzen = 3;

            while (true)
            {
                Console.Write("Podaj wage(kg):");

                if (float.TryParse(Console.ReadLine(), out _fWaga) == true && _fWaga > 0f && _fWaga < 1000f)
                {
                    break;
                }

                Console.WriteLine("Co piszesz gamoniu! :D Waga powinna byc wartoscia liczbowa z przedzialu >0 <1000");

                _iLicznikPowtorzen--;

                if (_iLicznikPowtorzen < 1)
                {
                    return;
                }
            }

            Console.WriteLine($"Waga={_fWaga}");

            while (true)
            {
                Console.Write("Podaj wzrost(m):");

                if (float.TryParse(Console.ReadLine(), out _fWzrost) == true && _fWzrost > 0f && _fWzrost < 4f)
                {
                    break;
                }

                Console.WriteLine("Co piszesz gamoniu! :D Wzrost powinien byc wartoscia liczbowa z przedzialu >0 <4");
            }

            _fBMI = _fWaga / (_fWzrost * _fWzrost);

            Console.WriteLine($"Współczynnik BMI={_fBMI:F2}");

            if (_fBMI < 18.5f)
            {
                Console.WriteLine("NIEDOWAGA!!!");
            }
            else if (_fBMI >= 18.5f && _fBMI <= 24.99f)
            {
                Console.WriteLine("Wszystko OK :D");
            }
            else
            {
                Console.WriteLine("NADWAGA!!!");
            }

            /*
            float _fWaga = 0f;
            float _fWzrost = 0f;

            Console.Write("Podaj wage(kg):");

            if (float.TryParse(Console.ReadLine(), out _fWaga) == true && _fWaga > 0f && _fWaga < 1000f)
            {
                Console.WriteLine($"Waga={_fWaga}");

                Console.Write("Podaj wzrost(m):");

                if (float.TryParse(Console.ReadLine(), out _fWzrost) == true && _fWzrost > 0f && _fWzrost < 4f)
                {
                    float _fBMI = 0f;

                    _fBMI = _fWaga / (_fWzrost * _fWzrost);

                    Console.WriteLine($"Współczynnik BMI={_fBMI:F2}");
                    
                    if (_fBMI < 18.5f)
                    {
                        Console.WriteLine("NIEDOWAGA!!!");
                    }
                    else if (_fBMI >= 18.5f && _fBMI <= 24.99f)
                    {
                        Console.WriteLine("Wszystko OK :D");
                    }
                    else
                    {
                        Console.WriteLine("NADWAGA!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Co piszesz gamoniu! :D Wzrost powinien byc wartoscia liczbowa z przedzialu >0 <4");
                }

            }
            else
            {
                Console.WriteLine("Co piszesz gamoniu! :D Waga powinna byc wartoscia liczbowa z przedzialu >0 <1000");
            }
            */
        }
    }
}
