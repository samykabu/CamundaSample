﻿using CamundaClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda_Tasks
{
    class Program
    {
       
        private static void Main(string[] args)
        {

            Console.WriteLine("Deploying models and start External Task Workers.\n\nPRESS ANY KEY TO STOP WORKERS.\n\n");

            CamundaEngineClient camunda = new CamundaEngineClient();
            camunda.Startup(); // Deploys all models to Camunda and Start all found ExternalTask-Workers
            Console.ReadLine(); // wait for ANY KEY
            camunda.Shutdown(); // Stop Task Workers
        }

        private static void writeTasksToConsole(CamundaEngineClient camunda)
        {
            var tasks = camunda.HumanTaskService.LoadTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine(task.Name);
            }
        }
    }
}