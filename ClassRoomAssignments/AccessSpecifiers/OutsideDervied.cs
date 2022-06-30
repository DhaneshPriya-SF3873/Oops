namespace AccessSpecifiers
{
    public class OutsideDervied:Outside.Pinternal
    {
        public void DisplayOutside()
        {
            System.Console.WriteLine(ProtectedInternalValue);
        }
    }
}