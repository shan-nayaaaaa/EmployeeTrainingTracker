namespace TrainingTrackerBusinessLayer
{
    public class Class1
    {
        private readonly TraineeDBMSService traineeDBMSService;
        private readonly TraineeJsonDataService traineeJsonDS = new TraineeJsonDataService();

        public Class1(TraineeDBMSService traineeDBMSService)
        {
            this.traineeDBMSService = traineeDBMSService;
        }

        public bool IsTraineeNumberCorrect(string userinput)
        {
            return traineeJsonDS.IsTraineeNumberExists(userinput);
        }
    }

    public class TraineeDBMSService
    {
    }
}
