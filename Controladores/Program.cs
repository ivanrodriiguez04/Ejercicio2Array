namespace Ejercicio2Array 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 19/12/2023 -> irodhan
    /// </summary>
    class Program 
    {
        /// <summary>
        /// Meotodo principal de la aplicacion
        /// 19/12/2023 -> irodhan
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            char[] mezcla = { 'a', 'e', 'b', 'o', 'u' };

            for (int i = 0; i < vocales.Length; i++) 
            {
                if (vocales[i] != mezcla[i]) 
                { 
                    Console.WriteLine(i);
                }
            }
        }
    }
}
