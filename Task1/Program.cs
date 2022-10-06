try
{
    throw new IndexOutOfRangeException();
}
catch (IndexOutOfRangeException e)
{ 
    Console.WriteLine(e.ToString());
}