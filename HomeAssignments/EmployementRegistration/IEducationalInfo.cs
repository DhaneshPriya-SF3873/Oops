namespace EmployementRegistration
{
     interface IEducationalInfo:IPersonalInfo
    {
          int SSLCMark { get; set; }
          int HSCMark { get; set; }
          double UGOverall { get; set; }
         
         
         
          void EducationalInformation();
         
         
    }
}