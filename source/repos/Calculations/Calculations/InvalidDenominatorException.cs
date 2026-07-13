namespace Calculations
{
    [Serializable]
    internal class InvalidDenominatorException : Exception
    {
        public InvalidDenominatorException()
        {
        }

        public InvalidDenominatorException(string? message) : base(message)
        {
        }

        public InvalidDenominatorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}