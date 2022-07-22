using System.Text.RegularExpressions;

namespace InputValidationLib
{
    public class InputValidation
    {
        public InputValidation()
        {

        }

        public static bool ValidateName(string nameToValidate)
        {
            Regex regexName = new Regex(@"^([a-zA-ZÀ-ÿ]+((-){1}[a-zA-ZÀ-ÿ])?){1,}$");

            if (regexName.IsMatch(nameToValidate))
            {
                return true;
            }

            return false;
        }

        public static bool ValidateLength(string stringToValidate, int length)
        {

            if (stringToValidate.Length <= length)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        /// <summary>
        /// Retourne true si le string est un nombre ou on nombre décimal avec un nombre de chiffres après la virgule définit entre 1 et 51
        /// </summary>
        /// <param name="stringToValidate"></param>
        /// <param name="numberOfDecimal">Nombre entier supérieur à zéro et inférieur à 51 </param>
        /// <returns></returns>
        public static bool ValidateStringIfOnlyNumbersOrDecimalNumbers(string stringToValidate, int numberOfDecimal = 10)
        {
            /*Regex regex = new(@"^[\d]{1,}([,.]{1}[\d]{1,})?$");*/

            if(numberOfDecimal < 1 || numberOfDecimal > 50)
            {
                return false;
            }
            else
            {
                Regex regex = new($"^[\\d]{{1,}}([,.]{{1}}[\\d]{{1,{numberOfDecimal}}})?$");

                if (regex.IsMatch(stringToValidate))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            
        }
        


        #region Date

        public static bool ValidateIfAStringIsADate(string stringToValidate)
        {
            /*if(DateTime.TryParse(stringToValidate, out DateTime result))
            {
                return true;
            }
            else
            {
                return false;
            }*/

            try
            {
                DateTime.Parse(stringToValidate);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool ValidateIfAStringIsAfterToday(string stringToValidate)
        {
            if(!ValidateIfAStringIsADate(stringToValidate))
            {
                return false;
            }
            else
            {
                return ValidateIfADateIsAfterToday(DateTime.Parse(stringToValidate));
            }
        }

        public static bool ValidateIfADateIsAfterToday(DateTime dateToValidate)
        {
            if(dateToValidate > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Date




    }
}