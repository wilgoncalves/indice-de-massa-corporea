using IMC.Entities;

namespace IMC.Services
{
    internal static class Calculator
    {
        public static double GetImc(User user)
        {
            return user.Weight / (user.Height * user.Height);
        }

        public static string Classification(double imc)
        {
            if (imc <= 18.5)
            {
                return "IMC abaixo do normal.";
            }
            else if (imc >= 18.6 &&  imc <= 24.9)
            {
                return "IMC normal.";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                return "Sobrepeso.";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                return "Obesidade grau 1!";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                return "Obesidade grau 2!!";
            }
            else
            {
                return "Obesidade grau 3!!!";
            }
        }
    }
}
