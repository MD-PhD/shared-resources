using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedResources
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new SharedResourcesStack(app, "SharedResourcesStack");
            app.Synth();
        }
    }
}
