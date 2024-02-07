namespace ColorBlindness_App.Models
{
    public class TestResult
    {
        public int TestResult_Id { get; set; }
        public int CorrectAnswer { get; set; }
        public int WrongAnswer { get; set; }
        public double Accuracy { get; set; }
        public bool IsColorBlind { get; set; }
        public virtual User User_Id { get; set; }
        public virtual Test Test_Id { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}
