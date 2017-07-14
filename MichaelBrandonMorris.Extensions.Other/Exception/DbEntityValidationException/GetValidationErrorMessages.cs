namespace MichaelBrandonMorris.Extensions.OtherExtensions.Exception.
    DbEntityValidationException
{
    public static class DbEntityValidationExceptionExtensions
    {
        public static string GetValidationErrorMessages(
            this System.Data.Entity.Validation.DbEntityValidationException
                exception)
        {
            var stringBuilder = new System.Text.StringBuilder();

            foreach (var entityValidationError in exception
                .EntityValidationErrors)
            {
                foreach (var validationError in entityValidationError
                    .ValidationErrors)
                {
                    stringBuilder.AppendLine(validationError.ErrorMessage);
                }
            }

            return stringBuilder.ToString();
        }
    }
}