namespace StudyProject
{
    public static class StringAlteration
    {
        public static void StringAlterationDemonstration()
        {
              string name = "kauan dos santos";

                // Vai pegar o numero correspondente desta leta em decimal
                int location = name.IndexOf("t");

                // pegar o ultimo nome
                string lastName = name.Substring(location);
        }
    }
}
