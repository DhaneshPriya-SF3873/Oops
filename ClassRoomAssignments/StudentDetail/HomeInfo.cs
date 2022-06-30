namespace StudentDetail
{
    public class HomeInfo:PersonalInfo
    {
        public int DoorNumber { get; set; }
        public string Address { get; set; }
        

        public void ShowHomeDetails()
        {
            DisplayPersonalInfo();
            System.Console.WriteLine("DoorNumber: "+DoorNumber+" "+"Address: "+" "+Address);
        }
        
        
        
    }
}