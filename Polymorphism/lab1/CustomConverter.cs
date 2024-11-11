namespace lab1
{
    public class CustomConverter
    {
        public void CConvert(string input, out int result)
        {
            result = Convert.ToInt32(input);
        }

        public void CConvert(string input, out double result)
        {
            result = Convert.ToDouble(input);
        }

        public void CConvert(string input, out DateTime result)
        {
            result = Convert.ToDateTime(input);
        }
    }
}
