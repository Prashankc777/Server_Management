namespace ServerManagement.Models
{
    public static class CitiesRepository
    {
        private static List<string> cities = ["toronto", "montreal", "Ottawa", "Calgary", "Halifax"];

        public static List<string> GetCities() => cities;
    }
}
