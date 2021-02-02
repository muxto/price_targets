﻿using PriceTargets.Core.Domain;

namespace PriceTargets.Core.Output.Console
{
    public class Output : IOutput
    {
        public void Publish()
        {
            System.Console.WriteLine();
        }

        public void Publish(string message)
        {
            System.Console.WriteLine(message);
        }

        public void PublishAtTheLine(string message)
        {
            System.Console.Write(message);
        }
    }
}
