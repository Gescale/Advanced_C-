namespace NullableNS
{
    public static class NullableVariables
    {
        public static void Run()
        {
            DateTime? date = null; // Option one of setting a nullable date
            Nullable<DateTime> dateNullable = null; // This is the other way of doing it.

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            // Console.WriteLine("Value(): " + date.Value); //This will cause an Exeption and crash the program because the value is null

            Console.WriteLine("Testing!");
            // Setting the date to Nullable date
            // DateTime date2 = date; //This will cause an error because date might be null
            // Setting the normal DateTime value to Nullable DateTime is strait forward
            DateTime date3 = date.GetValueOrDefault(); // This is how it should be done, if the date is null it will return the default value

            // If date has a value use that otherwise use today's date
            DateTime date3 = date ?? DateTime.Today;
            DateTime date4 = (date != null) ? date.GetValueOrDefault() : DateTime.Today; // This is the same as above
        }
    }
}