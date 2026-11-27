using System.Text.Json;
using TrainingTrackerDataLayer;

namespace TrainingTrackerBusinessLayer
{
    internal class TraineeJsonDataService
    {
        private readonly string filePath;

        public TraineeJsonDataService(string filePath = "trainees.json")
        {
            this.filePath = filePath;
        }

        // Returns true if a trainee with the given ID exists in the JSON file.
        public bool IsTraineeNumberExists(string traineeNumber)
        {
            if (string.IsNullOrWhiteSpace(traineeNumber) || !File.Exists(filePath))
            {
                return false;
            }

            var trainees = JsonSerializer.Deserialize<List<Class1>>(File.ReadAllText(filePath));
            return trainees?.Any(t => t.TraineeID == traineeNumber.Trim()) ?? false;
        }
    }
}
