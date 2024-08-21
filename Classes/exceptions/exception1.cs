using System;
using System.IO;

try
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine(myNumbers[3]);
}
catch (Exception ex)
{
    Console.WriteLine(ex+"\n\n[[[programa direito pfv]]]");
}
finally
{
    Console.WriteLine("o codigo foi encerrado");

}