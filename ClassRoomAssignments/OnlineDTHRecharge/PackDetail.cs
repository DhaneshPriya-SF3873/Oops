using System;
namespace OnlineDTHRecharge
{
    public class PackDetail
    {
        
        public string PackId { get; }
        public string PackName { get; set; }
        public double Price  { get; set; }
        public int Validity { get; set; }
        public int NumberOfChannels { get; set; }


        public PackDetail(string packId,string packName,double price,int validity,int numberOfChannels)
        {
            PackId=packId;
            PackName=packName;
            Price=price;
            Validity=validity;
            NumberOfChannels=numberOfChannels;
        }
        
        
        
        
        
        
        
        
        
        
    }
}