using System;

namespace EmployeeTrainingTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string trainees = "";
            string trainings = "";
            string status = "";

            int traineeInfo = 0;
            



            while (traineeInfo != 4)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|    Employee Training Tracker    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please Choose a Task to Perform (1-4): ");
                Console.WriteLine("(1) Trainees");
                Console.WriteLine("(2) Trainings");
                Console.WriteLine("(3) Training Status");
                Console.WriteLine("(4) Exit");
                Console.WriteLine("----------------------------------");

                Console.Write("Enter your choice: ");
                traineeInfo = Convert.ToInt16(Console.ReadLine());

                if (traineeInfo == 1)
                {
                    
                    bool traineeTab = true;
                    while (traineeTab)
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("   Welcome to Trainees Tab! Please Choose Task to Perform (1-3)   ");
                        Console.WriteLine("(1) Create New Trainee");
                        Console.WriteLine("(2) View Trainee List");
                        Console.WriteLine("(3) Exit");
                        Console.WriteLine("------------------------------------------------------------------");

                        Console.WriteLine("Enter your choice: ");
                        int traineeSelection = Convert.ToInt16(Console.ReadLine());

                        switch (traineeSelection)
                        {

                            case 1:
                                Console.Write("Enter Trainee's Name: ");
                                string traineeName = Console.ReadLine();
                                Console.Write("Enter Trainee's Position: ");
                                string traineePosition = Console.ReadLine();
                                trainees += $"Name: {traineeName}, Position: {traineePosition}\n";
                                Console.WriteLine($"'{traineeName}' in '{traineePosition}' is Successfully added to the Trainee List.");
                                // Saving the new trainee information to the list

                                Console.WriteLine("---------------------------");
                                Console.WriteLine("   Updated Trainee List   ");
                                Console.WriteLine("---------------------------");
                                Console.WriteLine($"Name: {traineeName}, Position: {traineePosition}");

                                Console.Write("Do you want to go back to Trainee Tab? (yes/no): ");
                                string anotherTrainee = Console.ReadLine().ToLower();

                                if (anotherTrainee == "no")
                                {
                                    Console.WriteLine("Thank you for using the Trainee Tab!");
                                    traineeTab = false;
                                }
                                break;

                            case 2:
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("|   Viewing Trainee List   |");
                                Console.WriteLine("---------------------------");
                                if (trainees == "")
                                {
                                    Console.WriteLine("No trainees found.");
                                }
                                else
                                {
                                    Console.WriteLine(trainees);
                                }
                                // Viewing the current list of trainees
                                break;
                            case 3:
                                Console.WriteLine("Thank you for using the Trainee Tab!");
                                traineeTab = false;
                                // Exit the trainee tab
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                }

                else if (traineeInfo == 2)
                {
                    
                    bool trainingTab = true;
                    while (trainingTab)
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("   Welcome to Training Tab! Please Choose Task to Perform (1-3)   ");
                        Console.WriteLine("(1) Create New Training");
                        Console.WriteLine("(2) View Training");
                        Console.WriteLine("(3) Exit");
                        Console.WriteLine("------------------------------------------------------------------");

                        Console.Write("Enter your choice: ");
                        int trainingSelection = Convert.ToInt16(Console.ReadLine());

                        switch (trainingSelection)
                        {
                            case 1:
                                Console.Write("Enter Training Name: ");
                                string trainingName = Console.ReadLine();
                                Console.Write("Enter Date (MM/DD/YYYY): ");
                                string trainingDate = Console.ReadLine();
                                trainings += $"Training: {trainingName} (Date: {trainingDate})\n";
                                Console.WriteLine($"'{trainingName}' by '{trainingDate}' is Successfully added to the Training List.");
                                // Saving the new training information to the list

                                Console.WriteLine("---------------------------");
                                Console.WriteLine("   Updated Training List   ");
                                Console.WriteLine("---------------------------");
                                Console.WriteLine($"Training: {trainingName} (Date: {trainingDate})");
                                

                                Console.Write("Do you want to go back to Training Tab? (yes/no): ");
                                string anotherTraining = Console.ReadLine().ToLower();

                                if (anotherTraining == "no")
                                {
                                    Console.WriteLine("Thank you for using the Training Tab!");
                                    trainingTab = false;
                                }
                                break;
                            case 2:
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("|   Viewing Training List   |");
                                Console.WriteLine("---------------------------");
                                if (trainings == "")
                                {
                                    Console.WriteLine("No trainings found.");
                                }
                                else
                                {
                                    Console.WriteLine(trainings);
                                }
                                // Viewing the current list of trainings
                                break;

                            case 3:
                                Console.WriteLine("Thank you for using the Training Tab!");
                                trainingTab = false;
                                // Exit the training tab
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                }

                else if (traineeInfo == 3)
                {
                    
                    bool trainingStatusTab = true;
                    while (trainingStatusTab)
                    {
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("   Welcome to Training Status Tab! Please Choose Task to Perform (1-3)   ");
                        Console.WriteLine("(1) Create New Training Status");
                        Console.WriteLine("(2) View Training Status");
                        Console.WriteLine("(3) Exit");
                        Console.WriteLine("-------------------------------------------------------------------------");

                        Console.Write("Enter your choice: ");
                        int statusSelection = Convert.ToInt16(Console.ReadLine());


                        switch (statusSelection)
                        {

                            case 1:
                                Console.Write("Enter Trainee's Name: ");
                                string traineeName2 = Console.ReadLine();
                                Console.Write("Enter Training Name: ");
                                string trainingName2 = Console.ReadLine();
                                Console.Write("Enter Training Status: ");
                                string statusInput = Console.ReadLine();
                                status += $"Trainee: {traineeName2}, Training: {trainingName2}, Status: {statusInput}\n";
                                Console.WriteLine($"'{traineeName2}' in '{trainingName2}' ('{statusInput}') is Successfully added to Training Status List.");
                                // Here you can add code to update the training status

                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("   Updated Training Status List   ");
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine($"Trainee: {traineeName2}, Training: {trainingName2}, Status: {statusInput}");
                                

                                Console.Write("Do you want to go back to Training Status Tab? (yes/no): ");
                                string anotherTraining = Console.ReadLine().ToLower();

                                if (anotherTraining == "no")
                                {
                                    Console.WriteLine("Thank you for using the Training Status Tab!");
                                    trainingStatusTab = false;
                                }
                                break;
                            case 2:
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("|   Viewing Training Status   |");
                                Console.WriteLine("------------------------------");
                                if (status == "")
                                {
                                    Console.WriteLine("No training status found.");
                                }
                                else
                                {
                                    Console.WriteLine(status);
                                   
                                }
                                // Here you can add code to view the training status
                                break;
                            case 3:
                                Console.WriteLine("Thank you for using the Training Status Tab!");
                                trainingStatusTab = false;
                                // Exit the training status tab
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine("|    Employee Training Tracker    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please Choose a Task to Perform (1-4): ");
                Console.WriteLine("(1) Trainees");
                Console.WriteLine("(2) Trainings");
                Console.WriteLine("(3) Training Status");
                Console.WriteLine("(4) Exit");
                Console.WriteLine("----------------------------------");

                Console.Write("Enter your choice: ");
                traineeInfo = Convert.ToInt16(Console.ReadLine());

            }

            



        }
    }
}
