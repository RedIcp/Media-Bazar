using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class Shift
    {


        [Required]
        public string MostPreferedTime { get; set; }
       

        [Required]
        public string Date { get; set; }
        [Required]
        public string LeastPreferedTime { get; set; }


        public Shift() { }
        public Shift(string mostPreferedTime, string date, string leastPreferedTime)
        {
            MostPreferedTime = mostPreferedTime;
            Date = date;
            LeastPreferedTime = leastPreferedTime;
        }

        public string GetInf()
        {
             return $"Date: {Date} MostPreferedTime: {MostPreferedTime}  LeastPreferedTime: {LeastPreferedTime}";
        }


    }
}
