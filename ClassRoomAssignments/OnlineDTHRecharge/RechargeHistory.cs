using System;
namespace OnlineDTHRecharge
{
    public class RechargeHistory
    {
        
        public string PackId { get; }
        public string UserId { get; }
        public DateTime RechargeDate { get; set; }
        public DateTime ValidTill { get; set; }



        public RechargeHistory(string packId,string userId,DateTime rechargeDate,DateTime validTill)
        {
            
            PackId=packId;
            UserId=userId;
            RechargeDate=rechargeDate;
            ValidTill=validTill;
        }
        
        
        
        
        
        
        
        
        
        
    }
}